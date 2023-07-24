namespace demo_webapi_dotnet_1.Models
{
    public class Drivers
    {
        public int Id { get; set; }

        public string DriverName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string VehicleName { get; set; } = string.Empty;

        public string VehicleLicense { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
