namespace FlowerShop.EF.Models
{
    public class ProductImage : Base
    {
        public string Uri { get; set; } = null!;
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
