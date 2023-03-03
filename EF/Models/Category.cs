namespace FlowerShop.EF.Models
{
    public class Category : Base
    {
        public string Name { get; set; } = null!;
        public string Tag { get; set; } = null!;

        public virtual IEnumerable<Product>? Products { get; set; }
    }
}
