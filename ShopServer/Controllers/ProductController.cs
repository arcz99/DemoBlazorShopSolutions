﻿using Microsoft.AspNetCore.Mvc;
using PhoneShopShatedLibrary.Contracts;
using PhoneShopShatedLibrary.Models;
using PhoneShopShatedLibrary.Responses;

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
        public async Task<ActionResult<List<Product>>> GetAllProducts(bool featured)
        {
            var products = await productService.GetAllProducts(featured); return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse>> AddProduct(Product model)
        {
            if (model is null) return BadRequest("Model is Null");
            var response = await productService.AddProduct(model);
            return Ok(response);
        }
    }
}
