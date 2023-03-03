namespace FlowerShop.EF.Models
{
    public class Product : Base
    {
        public string Name { get; set; } = null!;
        public uint Price { get; set; }
        public string? Description { get; set; }
        public string? Composition { get; set; }
        public string Size { get; set; } = null!;
        public uint? Diameter { get; set; }
        public uint? Height { get; set; }
        public string Tag { get; set; } = null!;

        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual IEnumerable<Cart>? Carts { get; set; }
        public virtual IEnumerable<CartProducts>? CartProducts { get; set; }
        public virtual IEnumerable<ProductImage>? Images { get; set; }
    }
}
