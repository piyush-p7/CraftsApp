using ContosoCrafts.WebSite.Services;
using Crafts_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crafts_App.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return this.ProductService.GetProducts();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery] string productID, [FromQuery] int newRating)
        {
            ProductService.AddRating(productID, newRating);
            return Ok();
        }
    }
}
