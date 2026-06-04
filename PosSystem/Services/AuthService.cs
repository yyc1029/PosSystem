using PosSystem.Data;
using PosSystem.Models;
using PosSystem.Utils;

namespace PosSystem.Services
{
    /// <summary>
    /// 登入驗證與目前登入者狀態（整個程式共用一份 CurrentUser）。
    /// </summary>
    public static class AuthService
    {
        private static readonly EmployeeRepository Repo = new EmployeeRepository();

        /// <summary>目前登入的使用者，未登入時為 null。</summary>
        public static Employee CurrentUser { get; private set; }

        /// <summary>
        /// 驗證帳密。成功則設定 CurrentUser 並回傳 true。
        /// </summary>
        public static bool Login(string username, string password)
        {
            var emp = Repo.GetByUsername(username);
            if (emp == null) return false;
            if (!PasswordHasher.Verify(password, emp.Password)) return false;

            CurrentUser = emp;
            return true;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static bool IsAdmin => CurrentUser != null && CurrentUser.IsAdmin;
    }
}
