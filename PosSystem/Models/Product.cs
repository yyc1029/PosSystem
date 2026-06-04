namespace PosSystem.Models
{
    /// <summary>
    /// 商品主檔。Stock 為現有庫存，低於 SafetyStock 時於介面以紅字警示。
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }   // join 查詢帶出，方便顯示
        public decimal Price { get; set; }          // 售價
        public decimal Cost { get; set; }           // 成本
        public int Stock { get; set; }              // 現有庫存
        public int SafetyStock { get; set; }        // 安全庫存量
        public bool IsActive { get; set; }

        /// <summary>庫存是否低於或等於安全庫存量。</summary>
        public bool IsLowStock => Stock <= SafetyStock;
    }
}
