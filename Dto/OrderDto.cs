using FlowerShop.EF.Models;

namespace FlowerShop.Dto
{
    public class OrderDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public string PickTime { get; set; }
        public string? City { get; set; }
        public string Address { get; set; }
        public PayType PayType { get; set; }
        public string Comment { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
    }

    public class ProductDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ItemCost { get; set; }
    }
}
