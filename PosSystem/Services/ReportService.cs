using System;
using System.Collections.Generic;
using System.Data.SQLite;
using PosSystem.Data;

namespace PosSystem.Services
{
    /// <summary>報表統計查詢：每日營收、熱銷商品、彙總數字。</summary>
    public class ReportService
    {
        /// <summary>一個 (標籤, 數值) 的統計列，供圖表與清單共用。</summary>
        public class StatRow
        {
            public string Label { get; set; }
            public decimal Value { get; set; }
        }

        /// <summary>指定區間內，每日的營收總額（依日期升冪）。</summary>
        public List<StatRow> GetDailyRevenue(DateTime from, DateTime to)
        {
            var list = new List<StatRow>();
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                "SELECT substr(CreatedAt,1,10) AS d, SUM(TotalAmount) " +
                "FROM SaleOrders WHERE CreatedAt >= @from AND CreatedAt <= @to " +
                "GROUP BY d ORDER BY d;", conn))
            {
                cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd 00:00:00"));
                cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd 23:59:59"));
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new StatRow
                        {
                            Label = r.GetString(0),
                            Value = r.IsDBNull(1) ? 0 : (decimal)r.GetDouble(1)
                        });
            }
            return list;
        }

        /// <summary>指定區間內，銷售數量前 N 名的商品。</summary>
        public List<StatRow> GetTopProducts(DateTime from, DateTime to, int topN = 5)
        {
            var list = new List<StatRow>();
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                "SELECT p.Name, SUM(si.Quantity) AS qty " +
                "FROM SaleItems si " +
                "JOIN SaleOrders so ON si.SaleOrderId = so.Id " +
                "JOIN Products p ON si.ProductId = p.Id " +
                "WHERE so.CreatedAt >= @from AND so.CreatedAt <= @to " +
                "GROUP BY si.ProductId ORDER BY qty DESC LIMIT @n;", conn))
            {
                cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd 00:00:00"));
                cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd 23:59:59"));
                cmd.Parameters.AddWithValue("@n", topN);
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new StatRow
                        {
                            Label = r.GetString(0),
                            Value = r.IsDBNull(1) ? 0 : Convert.ToDecimal(r.GetValue(1))
                        });
            }
            return list;
        }

        /// <summary>指定區間的彙總：總營收、訂單數、銷售件數。</summary>
        public (decimal revenue, int orderCount, int itemCount) GetSummary(DateTime from, DateTime to)
        {
            using (var conn = DbHelper.GetConnection())
            {
                decimal revenue = 0;
                int orders = 0, itemQty = 0;

                using (var cmd = new SQLiteCommand(
                    "SELECT IFNULL(SUM(TotalAmount),0), COUNT(*) FROM SaleOrders " +
                    "WHERE CreatedAt >= @from AND CreatedAt <= @to;", conn))
                {
                    cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd 00:00:00"));
                    cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd 23:59:59"));
                    using (var r = cmd.ExecuteReader())
                        if (r.Read())
                        {
                            revenue = (decimal)r.GetDouble(0);
                            orders = r.GetInt32(1);
                        }
                }

                using (var cmd = new SQLiteCommand(
                    "SELECT IFNULL(SUM(si.Quantity),0) FROM SaleItems si " +
                    "JOIN SaleOrders so ON si.SaleOrderId = so.Id " +
                    "WHERE so.CreatedAt >= @from AND so.CreatedAt <= @to;", conn))
                {
                    cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd 00:00:00"));
                    cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd 23:59:59"));
                    itemQty = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return (revenue, orders, itemQty);
            }
        }
    }
}
