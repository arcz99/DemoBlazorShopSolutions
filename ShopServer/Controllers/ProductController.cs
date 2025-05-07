using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneShopShatedLibrary.Contracts;

namespace ShopServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct productService;

        public ProductController(IProduct productService)
        {
            this.productService = productService;
        }
        [HttpGet]
    }
}
