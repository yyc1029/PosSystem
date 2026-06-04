using System;
using System.Windows.Forms;
using PosSystem.Data;
using PosSystem.Forms;

namespace PosSystem
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// 流程：初始化資料庫 → 顯示登入畫面 → 登入成功進入主畫面；
        /// 主畫面登出時回到登入畫面，關閉登入畫面則結束程式。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 首次執行會自動建立 pos.db、資料表與種子資料
            DbHelper.InitializeDatabase();

            while (true)
            {
                using (var login = new frmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        break;   // 使用者關閉登入視窗 → 結束程式
                }

                using (var main = new frmMain())
                {
                    // 主畫面以 DialogResult.Retry 表示「登出」，回到登入畫面再次登入
                    if (main.ShowDialog() != DialogResult.Retry)
                        break;   // 直接關閉主畫面 → 結束程式
                }
            }
        }
    }
}
