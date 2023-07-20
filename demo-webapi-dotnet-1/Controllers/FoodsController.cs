using Microsoft.AspNetCore.Mvc;

namespace demo_webapi_dotnet_1.Controllers
{
    [ApiController]
    [Route("api/food")]
    public class FoodsController : ControllerBase
    {
        private static Foods burger = new Foods()
        { Id = 1, Name = "Burger", Category = "Fast food", Description = "Extra cheese", Price = 30000 };

        private static List<Foods> foods = new List<Foods>();


        [HttpGet]
        public ActionResult<Foods> Get()
        {
            return Ok(burger);
        }

    }
}
