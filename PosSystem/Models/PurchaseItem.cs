namespace PosSystem.Models
{
    /// <summary>
    /// 進貨明細（單一商品一列）。
    /// </summary>
    public class PurchaseItem
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Subtotal => UnitCost * Quantity;
    }
}
