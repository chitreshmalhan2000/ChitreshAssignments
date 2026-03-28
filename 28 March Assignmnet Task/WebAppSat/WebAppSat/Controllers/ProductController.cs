using Microsoft.AspNetCore.Mvc;
using WebAppSat.Models;

namespace WebAppSat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _productService;

        public ProductController(IProduct productService)
        {
            _productService = productService;
        }

      
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll(int page = 1, int pageSize = 5)
        {
            var products = await _productService.GetAllProductsAsync(page, pageSize);
            return Ok(products);
        }

        // ✅ Get Product By Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null)
                return NotFound("Product not found");

            return Ok(product);
        }

     
        [HttpPost]
        public async Task<ActionResult<Product>> Create(Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var added = await _productService.AddProductAsync(product);

            return Ok(added);
        }

       
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Update(int id, Product product)
        {
            if (id != product.Id)
                return BadRequest("Product ID mismatch");

            var updated = await _productService.UpdateProductAsync(product);

            if (updated == null)
                return NotFound("Product not found");

            return Ok(updated);
        }

    
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            var deleted = await _productService.DeleteProductAsync(id);

            if (deleted == null)
                return NotFound("Product not found");

            return Ok(deleted);
        }
    }
}