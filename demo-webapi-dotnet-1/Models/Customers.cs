﻿namespace demo_webapi_dotnet_1.Models
{
    public class Customers
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public ICollection<Orders> Orders { get; set; }
    }
}
