using System;
using System.Collections.Generic;
using System.Data.SQLite;
using PosSystem.Models;
using PosSystem.Utils;

namespace PosSystem.Data
{
    /// <summary>員工 / 帳號資料存取。</summary>
    public class EmployeeRepository
    {
        private static Employee Read(SQLiteDataReader r)
        {
            return new Employee
            {
                Id = r.GetInt32(0),
                Username = r.GetString(1),
                Password = r.GetString(2),
                FullName = r.IsDBNull(3) ? "" : r.GetString(3),
                Role = r.GetString(4),
                CreatedAt = DateTime.Parse(r.GetString(5))
            };
        }

        private const string BaseSelect =
            "SELECT Id, Username, Password, FullName, Role, CreatedAt FROM Employees";

        public List<Employee> GetAll()
        {
            var list = new List<Employee>();
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(BaseSelect + " ORDER BY Id;", conn))
            using (var r = cmd.ExecuteReader())
                while (r.Read())
                    list.Add(Read(r));
            return list;
        }

        /// <summary>依帳號取得員工，找不到回傳 null。</summary>
        public Employee GetByUsername(string username)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(BaseSelect + " WHERE Username = @u;", conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                using (var r = cmd.ExecuteReader())
                    return r.Read() ? Read(r) : null;
            }
        }

        /// <summary>新增員工，密碼會自動雜湊。</summary>
        public int Add(Employee e, string plainPassword)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                "INSERT INTO Employees (Username, Password, FullName, Role, CreatedAt) " +
                "VALUES (@u, @p, @f, @r, @c); SELECT last_insert_rowid();", conn))
            {
                cmd.Parameters.AddWithValue("@u", e.Username);
                cmd.Parameters.AddWithValue("@p", PasswordHasher.Hash(plainPassword));
                cmd.Parameters.AddWithValue("@f", (object)e.FullName ?? "");
                cmd.Parameters.AddWithValue("@r", e.Role);
                cmd.Parameters.AddWithValue("@c", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                return (int)(long)cmd.ExecuteScalar();
            }
        }

        /// <summary>更新員工基本資料（不含密碼）。</summary>
        public void Update(Employee e)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                "UPDATE Employees SET Username=@u, FullName=@f, Role=@r WHERE Id=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@u", e.Username);
                cmd.Parameters.AddWithValue("@f", (object)e.FullName ?? "");
                cmd.Parameters.AddWithValue("@r", e.Role);
                cmd.Parameters.AddWithValue("@id", e.Id);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>變更密碼（自動雜湊）。</summary>
        public void ChangePassword(int id, string plainPassword)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand(
                "UPDATE Employees SET Password=@p WHERE Id=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@p", PasswordHasher.Hash(plainPassword));
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbHelper.GetConnection())
            using (var cmd = new SQLiteCommand("DELETE FROM Employees WHERE Id=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
