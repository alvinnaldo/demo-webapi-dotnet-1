using System.ComponentModel.DataAnnotations.Schema;

namespace demo_webapi_dotnet_1.Models
{
    public class OrderItems
    {
        public int Id { get; set; }

        [ForeignKey("Orders")]
        public int OrderId { get; set; }

        public Orders Orders { get; set; }

        [ForeignKey("Foods")]
        public int FoodId { get; set; }

        public ICollection<Foods> Foods { get; set; }

    }
}
