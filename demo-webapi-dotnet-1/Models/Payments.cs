namespace demo_webapi_dotnet_1.Models
{
    public class Payments
    {

        public int Id { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;

        public int Amount { get; set; }

        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;

        public Orders Orders { get; set; }
    }

    public enum PaymentStatus
    {
        Pending,
        Complete,
        Failed,
        Refunded
    }
}
