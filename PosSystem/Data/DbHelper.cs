using System;
using System.Data.SQLite;
using System.IO;
using PosSystem.Utils;

namespace PosSystem.Data
{
    /// <summary>
    /// SQLite 資料庫共用工具：負責連線字串、自動建表與種子資料。
    /// 資料庫檔 pos.db 會放在執行檔同目錄，首次執行時自動建立。
    /// </summary>
    public static class DbHelper
    {
        private static readonly string DbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pos.db");

        public static string ConnectionString =>
            $"Data Source={DbPath};Version=3;";

        /// <summary>建立並開啟一個資料庫連線（呼叫端負責 using 釋放）。</summary>
        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            // 開啟外鍵約束
            using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                cmd.ExecuteNonQuery();
            return conn;
        }

        /// <summary>
        /// 程式啟動時呼叫一次：若資料庫不存在則建立檔案、建立資料表並寫入種子資料。
        /// </summary>
        public static void InitializeDatabase()
        {
            bool isNew = !File.Exists(DbPath);
            if (isNew)
                SQLiteConnection.CreateFile(DbPath);

            using (var conn = GetConnection())
            {
                CreateTables(conn);
                SeedData(conn);
            }
        }

        private static void CreateTables(SQLiteConnection conn)
        {
            string sql = @"
CREATE TABLE IF NOT EXISTS Employees (
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
    Username  TEXT NOT NULL UNIQUE,
    Password  TEXT NOT NULL,
    FullName  TEXT,
    Role      TEXT NOT NULL DEFAULT 'Cashier',
    CreatedAt TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS Categories (
    Id   INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS Products (
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    Barcode     TEXT UNIQUE,
    Name        TEXT NOT NULL,
    CategoryId  INTEGER,
    Price       REAL NOT NULL DEFAULT 0,
    Cost        REAL NOT NULL DEFAULT 0,
    Stock       INTEGER NOT NULL DEFAULT 0,
    SafetyStock INTEGER NOT NULL DEFAULT 0,
    IsActive    INTEGER NOT NULL DEFAULT 1,
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);

CREATE TABLE IF NOT EXISTS SaleOrders (
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderNo     TEXT NOT NULL UNIQUE,
    EmployeeId  INTEGER,
    TotalAmount REAL NOT NULL DEFAULT 0,
    PayAmount   REAL NOT NULL DEFAULT 0,
    Change      REAL NOT NULL DEFAULT 0,
    CreatedAt   TEXT NOT NULL,
    FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
);

CREATE TABLE IF NOT EXISTS SaleItems (
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    SaleOrderId INTEGER NOT NULL,
    ProductId   INTEGER NOT NULL,
    Quantity    INTEGER NOT NULL,
    UnitPrice   REAL NOT NULL,
    FOREIGN KEY (SaleOrderId) REFERENCES SaleOrders(Id),
    FOREIGN KEY (ProductId)   REFERENCES Products(Id)
);

CREATE TABLE IF NOT EXISTS PurchaseOrders (
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderNo     TEXT NOT NULL UNIQUE,
    EmployeeId  INTEGER,
    TotalCost   REAL NOT NULL DEFAULT 0,
    CreatedAt   TEXT NOT NULL,
    FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
);

CREATE TABLE IF NOT EXISTS PurchaseItems (
    Id              INTEGER PRIMARY KEY AUTOINCREMENT,
    PurchaseOrderId INTEGER NOT NULL,
    ProductId       INTEGER NOT NULL,
    Quantity        INTEGER NOT NULL,
    UnitCost        REAL NOT NULL,
    FOREIGN KEY (PurchaseOrderId) REFERENCES PurchaseOrders(Id),
    FOREIGN KEY (ProductId)       REFERENCES Products(Id)
);";

            using (var cmd = new SQLiteCommand(sql, conn))
                cmd.ExecuteNonQuery();
        }

        /// <summary>若資料表為空，寫入預設帳號、分類與範例商品，方便首次使用與 DEMO。</summary>
        private static void SeedData(SQLiteConnection conn)
        {
            // 預設管理員與收銀員帳號
            if (CountRows(conn, "Employees") == 0)
            {
                string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                InsertEmployee(conn, "admin", "admin", "系統管理員", "Admin", nowStr);
                InsertEmployee(conn, "cashier", "1234", "預設收銀員", "Cashier", nowStr);
            }

            // 預設分類
            if (CountRows(conn, "Categories") == 0)
            {
                foreach (var name in new[] { "飲料", "零食", "日用品", "菸酒", "鮮食" })
                    ExecNonQuery(conn, "INSERT INTO Categories (Name) VALUES (@n);",
                        ("@n", name));
            }

            // 範例商品
            if (CountRows(conn, "Products") == 0)
            {
                AddProduct(conn, "4710001000017", "礦泉水 600ml", 1, 20, 10, 50, 20);
                AddProduct(conn, "4710001000024", "可樂 330ml", 1, 25, 13, 40, 15);
                AddProduct(conn, "4710002000018", "洋芋片", 2, 35, 20, 30, 10);
                AddProduct(conn, "4710002000025", "巧克力棒", 2, 30, 16, 8, 12);   // 低庫存範例
                AddProduct(conn, "4710003000019", "衛生紙", 3, 80, 50, 25, 8);
                AddProduct(conn, "4710005000011", "御飯糰", 5, 30, 18, 20, 10);
            }
        }

        private static void InsertEmployee(SQLiteConnection conn, string user, string pwd,
            string fullName, string role, string nowStr)
        {
            ExecNonQuery(conn,
                "INSERT INTO Employees (Username, Password, FullName, Role, CreatedAt) " +
                "VALUES (@u, @p, @f, @r, @c);",
                ("@u", user), ("@p", PasswordHasher.Hash(pwd)),
                ("@f", fullName), ("@r", role), ("@c", nowStr));
        }

        private static void AddProduct(SQLiteConnection conn, string barcode, string name,
            int categoryId, decimal price, decimal cost, int stock, int safety)
        {
            ExecNonQuery(conn,
                "INSERT INTO Products (Barcode, Name, CategoryId, Price, Cost, Stock, SafetyStock, IsActive) " +
                "VALUES (@b, @n, @cat, @price, @cost, @stock, @safety, 1);",
                ("@b", barcode), ("@n", name), ("@cat", categoryId),
                ("@price", price), ("@cost", cost), ("@stock", stock), ("@safety", safety));
        }

        // ---- 小工具 ----

        private static long CountRows(SQLiteConnection conn, string table)
        {
            using (var cmd = new SQLiteCommand($"SELECT COUNT(*) FROM {table};", conn))
                return (long)cmd.ExecuteScalar();
        }

        private static void ExecNonQuery(SQLiteConnection conn, string sql,
            params (string, object)[] ps)
        {
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                foreach (var (name, val) in ps)
                    cmd.Parameters.AddWithValue(name, val);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
