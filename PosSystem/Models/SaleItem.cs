namespace PosSystem.Models
{
    /// <summary>
    /// 銷售明細（單一商品一列）。
    /// </summary>
    public class SaleItem
    {
        public int Id { get; set; }
        public int SaleOrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }     // join / 購物車帶出
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal => UnitPrice * Quantity;
    }
}
