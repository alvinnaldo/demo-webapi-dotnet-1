namespace demo_webapi_dotnet_1.Models
{
    public class Merchants
    {
        public int Id { get; set; }

        public string MerchantName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public ICollection<Foods> Foods { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
