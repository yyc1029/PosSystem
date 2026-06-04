using System;

namespace PosSystem.Models
{
    /// <summary>
    /// 員工 / 系統使用者。Role 區分管理員 (Admin) 與收銀員 (Cashier)。
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }   // 以 SHA256 雜湊後儲存
        public string FullName { get; set; }
        public string Role { get; set; }        // "Admin" 或 "Cashier"
        public DateTime CreatedAt { get; set; }

        public bool IsAdmin => string.Equals(Role, "Admin", StringComparison.OrdinalIgnoreCase);

        public string RoleText => IsAdmin ? "管理員" : "收銀員";
    }
}
