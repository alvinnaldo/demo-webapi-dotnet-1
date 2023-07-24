using System.ComponentModel.DataAnnotations.Schema;

namespace demo_webapi_dotnet_1.Models
{
    public class Foods
    {
        public int Id { get; set; }

        [ForeignKey("Merchants")]
        public int MerchantId { get; set; }

        public Merchants Merchants { get; set; }

        public string? Name { get; set; }

        public string? Category { get; set; }

        public int Price { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }


    }
}
