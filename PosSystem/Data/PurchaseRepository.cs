using System;
using System.Collections.Generic;
using System.Data.SQLite;
using PosSystem.Models;

namespace PosSystem.Data
{
    /// <summary>
    /// 進貨資料存取。Receive 在單一交易內寫入進貨單、明細並增加庫存。
    /// </summary>
    public class PurchaseRepository
    {
        /// <summary>進貨入庫。成功回傳進貨單號；失敗則整筆 Rollback。</summary>
        public string Receive(int employeeId, List<PurchaseItem> items)
        {
            if (items == null || items.Count == 0)
                throw new InvalidOperationException("進貨清單是空的。");

            decimal total = 0;
            foreach (var it in items) total += it.Subtotal;

            string orderNo = "P" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

            using (var conn = DbHelper.GetConnection())
            using (var tx = conn.BeginTransaction())
            {
                try
                {
                    long purchaseId;
                    using (var cmd = new SQLiteCommand(
                        "INSERT INTO PurchaseOrders (OrderNo, EmployeeId, TotalCost, CreatedAt) " +
                        "VALUES (@no, @emp, @total, @c); SELECT last_insert_rowid();", conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@no", orderNo);
                        cmd.Parameters.AddWithValue("@emp", employeeId);
                        cmd.Parameters.AddWithValue("@total", (double)total);
                        cmd.Parameters.AddWithValue("@c", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        purchaseId = (long)cmd.ExecuteScalar();
                    }

                    foreach (var it in items)
                    {
                        using (var cmd = new SQLiteCommand(
                            "INSERT INTO PurchaseItems (PurchaseOrderId, ProductId, Quantity, UnitCost) " +
                            "VALUES (@po, @p, @q, @cost);", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@po", purchaseId);
                            cmd.Parameters.AddWithValue("@p", it.ProductId);
                            cmd.Parameters.AddWithValue("@q", it.Quantity);
                            cmd.Parameters.AddWithValue("@cost", (double)it.UnitCost);
                            cmd.ExecuteNonQuery();
                        }

                        using (var cmd = new SQLiteCommand(
                            "UPDATE Products SET Stock = Stock + @q WHERE Id = @p;", conn, tx))
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

        /// <summary>查詢進貨單（可指定日期區間）。</summary>
        public List<PurchaseOrder> GetOrders(DateTime? from = null, DateTime? to = null)
        {
            var list = new List<PurchaseOrder>();
            string sql = @"
SELECT po.Id, po.OrderNo, po.EmployeeId, IFNULL(e.FullName, e.Username),
       po.TotalCost, po.CreatedAt
FROM PurchaseOrders po
LEFT JOIN Employees e ON po.EmployeeId = e.Id";
            var conds = new List<string>();
            if (from.HasValue) conds.Add("po.CreatedAt >= @from");
            if (to.HasValue) conds.Add("po.CreatedAt <= @to");
            if (conds.Count > 0) sql += " WHERE " + string.Join(" AND ", conds);
            sql += " ORDER BY po.Id DESC;";

            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                if (from.HasValue)
                    cmd.Parameters.AddWithValue("@from", from.Value.ToString("yyyy-MM-dd 00:00:00"));
                if (to.HasValue)
                    cmd.Parameters.AddWithValue("@to", to.Value.ToString("yyyy-MM-dd 23:59:59"));
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new PurchaseOrder
                        {
                            Id = r.GetInt32(0),
                            OrderNo = r.GetString(1),
                            EmployeeId = r.IsDBNull(2) ? 0 : r.GetInt32(2),
                            EmployeeName = r.IsDBNull(3) ? "" : r.GetString(3),
                            TotalCost = (decimal)r.GetDouble(4),
                            CreatedAt = DateTime.Parse(r.GetString(5))
                        });
            }
            return list;
        }
    }
}
