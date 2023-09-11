using ContosoCrafts.WebSite.Services;
using Crafts_App.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JokesApp.Pages
{
    public class CraftsModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public JsonFileProductService ProductService { get; set; }
        public IEnumerable<Product> Products { get; private set; }
        public int num = 0;

        public CraftsModel(ILogger<PrivacyModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
            num = 1;
        }
    }
}