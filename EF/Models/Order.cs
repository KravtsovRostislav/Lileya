namespace FlowerShop.EF.Models
{
    public class Order : Base
    {
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public DeliveryType DeliveryType { get; set; } = DeliveryType.Selfpick;
        public PayType PayType { get; set; } = PayType.Cash;
        public string? PickTime { get; set; }
        public string? City { get; set; }
        public string? Address { get;set; }
        public string? Comment { get; set; }

        public int CartId { get; set; }
        public virtual Cart? Cart { get; set; }
    }

    public enum DeliveryType
    {
        Selfpick = 0,
        Courier = 1
    }

    public enum PayType
    {
        Cash = 0,
        Card = 1
    }
}
