using System;
using System.Security.Cryptography;
using System.Text;

namespace PosSystem.Utils
{
    /// <summary>
    /// 密碼雜湊工具。使用 SHA256，避免在資料庫中以明碼儲存密碼。
    /// </summary>
    public static class PasswordHasher
    {
        public static string Hash(string plainText)
        {
            if (plainText == null) plainText = string.Empty;
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                var sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        /// <summary>比對明碼與雜湊值是否相符。</summary>
        public static bool Verify(string plainText, string hash)
        {
            return string.Equals(Hash(plainText), hash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
