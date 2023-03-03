namespace FlowerShop.EF.Models
{
    public class CartProducts
    {
        public int Quantity { get; set; }
        public int ItemCost { get; set; }
        public int TotalSum
        {
            get
            {
                return Quantity * ItemCost;
            }
        }

        public int CartId { get; set; }
        public virtual Cart? Cart { get; set; }

        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
