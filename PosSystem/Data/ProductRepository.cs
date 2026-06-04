using System.Collections.Generic;
using System.Data.SQLite;
using PosSystem.Models;

namespace PosSystem.Data
{
    /// <summary>商品資料存取：CRUD、搜尋、低庫存查詢、庫存調整。</summary>
    public class ProductRepository
    {
        private const string BaseSelect = @"
SELECT p.Id, p.Barcode, p.Name, p.CategoryId, IFNULL(c.Name,''),
       p.Price, p.Cost, p.Stock, p.SafetyStock, p.IsActive
FROM Products p
LEFT JOIN Categories c ON p.CategoryId = c.Id";

        private static Product Read(SQLiteDataReader r)
        {
            return new Product
            {
                Id = r.GetInt32(0),
                Barcode = r.IsDBNull(1) ? "" : r.GetString(1),
                Name = r.GetString(2),
                CategoryId = r.IsDBNull(3) ? 0 : r.GetInt32(3),
                CategoryName = r.GetString(4),
                Price = (decimal)r.GetDouble(5),
                Cost = (decimal)r.GetDouble(6),
                Stock = r.GetInt32(7),
                SafetyStock = r.GetInt32(8),
                IsActive = r.GetInt32(9) == 1
            };
        }

        /// <summary>取得商品清單。keyword 會比對名稱或條碼；activeOnly 只取上架商品。</summary>
        public List<Product> GetAll(string keyword = null, bool activeOnly = false)
        {
            var list = new List<Product>();
            string sql = BaseSelect;
            var conditions = new List<string>();
            if (activeOnly) conditions.Add("p.IsActive = 1");
            if (!string.IsNullOrWhiteSpace(keyword))
                conditions.Add("(p.Name LIKE @kw OR p.Barcode LIKE @kw)");
            if (conditions.Count > 0)
                sql += " WHERE " + string.Join(" AND ", conditions);
            sql += " ORDER BY p.Id;";

            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                if (!string.IsNullOrWhiteSpace(keyword))
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(Read(r));
            }
            return list;
        }

        /// <summary>依條碼取得單一上架商品（POS 掃描用），找不到回傳 null。</summary>
        public Product GetByBarcode(string barcode)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                BaseSelect + " WHERE p.Barcode = @b AND p.IsActive = 1;", conn))
            {
                cmd.Parameters.AddWithValue("@b", barcode);
                using (var r = cmd.ExecuteReader())
                    return r.Read() ? Read(r) : null;
            }
        }

        /// <summary>低庫存商品（Stock &lt;= SafetyStock）。</summary>
        public List<Product> GetLowStock()
        {
            var list = new List<Product>();
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                BaseSelect + " WHERE p.Stock <= p.SafetyStock AND p.IsActive = 1 ORDER BY p.Stock;", conn))
            using (var r = cmd.ExecuteReader())
                while (r.Read())
                    list.Add(Read(r));
            return list;
        }

        public int Add(Product p)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                "INSERT INTO Products (Barcode, Name, CategoryId, Price, Cost, Stock, SafetyStock, IsActive) " +
                "VALUES (@b, @n, @cat, @price, @cost, @stock, @safety, @act); SELECT last_insert_rowid();", conn))
            {
                Bind(cmd, p);
                return (int)(long)cmd.ExecuteScalar();
            }
        }

        public void Update(Product p)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                "UPDATE Products SET Barcode=@b, Name=@n, CategoryId=@cat, Price=@price, " +
                "Cost=@cost, Stock=@stock, SafetyStock=@safety, IsActive=@act WHERE Id=@id;", conn))
            {
                Bind(cmd, p);
                cmd.Parameters.AddWithValue("@id", p.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand("DELETE FROM Products WHERE Id=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        private static void Bind(SQLiteCommand cmd, Product p)
        {
            cmd.Parameters.AddWithValue("@b", (object)p.Barcode ?? "");
            cmd.Parameters.AddWithValue("@n", p.Name);
            cmd.Parameters.AddWithValue("@cat", p.CategoryId);
            cmd.Parameters.AddWithValue("@price", (double)p.Price);
            cmd.Parameters.AddWithValue("@cost", (double)p.Cost);
            cmd.Parameters.AddWithValue("@stock", p.Stock);
            cmd.Parameters.AddWithValue("@safety", p.SafetyStock);
            cmd.Parameters.AddWithValue("@act", p.IsActive ? 1 : 0);
        }
    }
}
