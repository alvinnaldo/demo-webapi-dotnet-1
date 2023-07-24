using System.ComponentModel.DataAnnotations.Schema;

namespace demo_webapi_dotnet_1.Models
{
    public class Orders
    {
        public int Id { get; set; }

        public string InvoiceNo { get; set; } = string.Empty;

        [ForeignKey("Merchants")]
        public int MerchantId { get; set; }
        public Merchants Merchants { get; set; }

        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }

        public float Distance { get; set; }

        public int DeliveryCost { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Waiting;

        [ForeignKey("Drivers")]
        public int DriverId { get; set; }
        public Drivers Drivers { get; set; }

        [ForeignKey("Payments")]
        public int PaymentId { get; set; }
        public Payments Payments { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }

    }

    public enum OrderStatus
    {
        Waiting,
        OrderConfirmed,
        Cooking,
        Delivering,
        OrderSent
    }
}
