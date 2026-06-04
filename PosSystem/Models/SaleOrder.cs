using System;
using System.Collections.Generic;

namespace PosSystem.Models
{
    /// <summary>
    /// 銷售單（主檔）。一筆結帳對應一張 SaleOrder 與多筆 SaleItem。
    /// </summary>
    public class SaleOrder
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }         // 單號，例如 S20260604153012
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }    // join 帶出
        public decimal TotalAmount { get; set; }    // 應收總額
        public decimal PayAmount { get; set; }      // 實收
        public decimal Change { get; set; }         // 找零
        public DateTime CreatedAt { get; set; }

        public List<SaleItem> Items { get; set; } = new List<SaleItem>();
    }
}
