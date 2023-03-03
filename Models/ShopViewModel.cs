using FlowerShop.EF.Models;

namespace FlowerShop.Models
{
    public class ShopViewModel
    {
        public IEnumerable<Category>? Categories { get; set; }
    }
}
