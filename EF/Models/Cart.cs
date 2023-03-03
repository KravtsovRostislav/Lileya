namespace FlowerShop.EF.Models
{
    public class Cart : Base
    {
        public uint MoneyAmount { get; set; }
        public uint DeliveryCost { get; set; } = 0;
        public uint TotalMoneyAmount
        {
            get
            {
                return MoneyAmount + DeliveryCost;
            }
        }

        public virtual Order? Order { get; set; }
        public virtual IEnumerable<Product>? Products { get; set; }
        public virtual IEnumerable<CartProducts>? CartProducts { get; set; }
    }
}
