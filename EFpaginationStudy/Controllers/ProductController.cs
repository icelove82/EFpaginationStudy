using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFpaginationStudy.Data;

namespace EFpaginationStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("page")]
        public async Task<ActionResult<ProductResponse>> GetPagingProducts(int page)
        {
            var perPage = 3f;
            var allPage = Math.Ceiling(_context.Products.Count() / perPage);

            var products = await _context.Products
                .Skip((page - 1) * (int)perPage)
                .Take((int)perPage)
                .ToListAsync();

            var response = new ProductResponse
            {
                Pages = (int)allPage,
                CurrentPage = page,
                Products = products
            };

            return Ok(response);
        }
    }
}
