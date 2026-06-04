namespace PosSystem.Models
{
    /// <summary>
    /// 商品分類（例如：飲料、零食、日用品）。
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
