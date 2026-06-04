using System;
using System.Collections.Generic;
using System.Data.SQLite;
using PosSystem.Models;

namespace PosSystem.Data
{
    /// <summary>
    /// 銷售資料存取。Checkout 為核心：在單一交易內寫入銷售單、明細並扣減庫存。
    /// </summary>
    public class SaleRepository
    {
        /// <summary>
        /// 結帳。成功回傳產生的銷售單號；任一步失敗則整筆 Rollback 並丟出例外。
        /// </summary>
        public string Checkout(int employeeId, List<SaleItem> items, decimal payAmount)
        {
            if (items == null || items.Count == 0)
                throw new InvalidOperationException("購物車是空的，無法結帳。");

            decimal total = 0;
            foreach (var it in items) total += it.Subtotal;
            if (payAmount < total)
                throw new InvalidOperationException("實收金額不足。");

            string orderNo = "S" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            decimal change = payAmount - total;

            using (var conn = DbHelper.GetConnection())
            using (var tx = conn.BeginTransaction())
            {
                try
                {
                    // 1. 寫入銷售單主檔
                    long saleId;
                    using (var cmd = new SQLiteCommand(
                        "INSERT INTO SaleOrders (OrderNo, EmployeeId, TotalAmount, PayAmount, Change, CreatedAt) " +
                        "VALUES (@no, @emp, @total, @pay, @chg, @c); SELECT last_insert_rowid();", conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@no", orderNo);
                        cmd.Parameters.AddWithValue("@emp", employeeId);
                        cmd.Parameters.AddWithValue("@total", (double)total);
                        cmd.Parameters.AddWithValue("@pay", (double)payAmount);
                        cmd.Parameters.AddWithValue("@chg", (double)change);
                        cmd.Parameters.AddWithValue("@c", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        saleId = (long)cmd.ExecuteScalar();
                    }

                    // 2. 逐項寫入明細並扣庫存（先檢查庫存是否足夠）
                    foreach (var it in items)
                    {
                        int stock = GetStock(conn, tx, it.ProductId);
                        if (stock < it.Quantity)
                            throw new InvalidOperationException(
                                $"商品「{it.ProductName}」庫存不足（現有 {stock}，需要 {it.Quantity}）。");

                        using (var cmd = new SQLiteCommand(
                            "INSERT INTO SaleItems (SaleOrderId, ProductId, Quantity, UnitPrice) " +
                            "VALUES (@s, @p, @q, @price);", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@s", saleId);
                            cmd.Parameters.AddWithValue("@p", it.ProductId);
                            cmd.Parameters.AddWithValue("@q", it.Quantity);
                            cmd.Parameters.AddWithValue("@price", (double)it.UnitPrice);
                            cmd.ExecuteNonQuery();
                        }

                        using (var cmd = new SQLiteCommand(
                            "UPDATE Products SET Stock = Stock - @q WHERE Id = @p;", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@q", it.Quantity);
                            cmd.Parameters.AddWithValue("@p", it.ProductId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tx.Commit();
                    return orderNo;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static int GetStock(SQLiteConnection conn, SQLiteTransaction tx, int productId)
        {
            using (var cmd = new SQLiteCommand("SELECT Stock FROM Products WHERE Id=@p;", conn, tx))
            {
                cmd.Parameters.AddWithValue("@p", productId);
                object o = cmd.ExecuteScalar();
                if (o == null) throw new InvalidOperationException("商品不存在。");
                return Convert.ToInt32(o);
            }
        }

        /// <summary>查詢銷售單（可指定日期區間），含經手員工姓名。</summary>
        public List<SaleOrder> GetOrders(DateTime? from = null, DateTime? to = null)
        {
            var list = new List<SaleOrder>();
            string sql = @"
SELECT s.Id, s.OrderNo, s.EmployeeId, IFNULL(e.FullName, e.Username),
       s.TotalAmount, s.PayAmount, s.Change, s.CreatedAt
FROM SaleOrders s
LEFT JOIN Employees e ON s.EmployeeId = e.Id";
            var conds = new List<string>();
            if (from.HasValue) conds.Add("s.CreatedAt >= @from");
            if (to.HasValue) conds.Add("s.CreatedAt <= @to");
            if (conds.Count > 0) sql += " WHERE " + string.Join(" AND ", conds);
            sql += " ORDER BY s.Id DESC;";

            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                if (from.HasValue)
                    cmd.Parameters.AddWithValue("@from", from.Value.ToString("yyyy-MM-dd 00:00:00"));
                if (to.HasValue)
                    cmd.Parameters.AddWithValue("@to", to.Value.ToString("yyyy-MM-dd 23:59:59"));
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new SaleOrder
                        {
                            Id = r.GetInt32(0),
                            OrderNo = r.GetString(1),
                            EmployeeId = r.IsDBNull(2) ? 0 : r.GetInt32(2),
                            EmployeeName = r.IsDBNull(3) ? "" : r.GetString(3),
                            TotalAmount = (decimal)r.GetDouble(4),
                            PayAmount = (decimal)r.GetDouble(5),
                            Change = (decimal)r.GetDouble(6),
                            CreatedAt = DateTime.Parse(r.GetString(7))
                        });
            }
            return list;
        }
    }
}
