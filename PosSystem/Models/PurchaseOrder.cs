using System;
using System.Collections.Generic;

namespace PosSystem.Models
{
    /// <summary>
    /// 進貨單（主檔）。一次進貨對應一張 PurchaseOrder 與多筆 PurchaseItem。
    /// </summary>
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }         // 單號，例如 P20260604153012
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }    // join 帶出
        public decimal TotalCost { get; set; }      // 進貨總成本
        public DateTime CreatedAt { get; set; }

        public List<PurchaseItem> Items { get; set; } = new List<PurchaseItem>();
    }
}
