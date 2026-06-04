using System.Collections.Generic;
using System.Data.SQLite;
using PosSystem.Models;

namespace PosSystem.Data
{
    /// <summary>商品分類資料存取。</summary>
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            var list = new List<Category>();
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand("SELECT Id, Name FROM Categories ORDER BY Id;", conn))
            using (var r = cmd.ExecuteReader())
            {
                while (r.Read())
                    list.Add(new Category { Id = r.GetInt32(0), Name = r.GetString(1) });
            }
            return list;
        }

        public int Add(string name)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                "INSERT INTO Categories (Name) VALUES (@n); SELECT last_insert_rowid();", conn))
            {
                cmd.Parameters.AddWithValue("@n", name);
                return (int)(long)cmd.ExecuteScalar();
            }
        }
    }
}
