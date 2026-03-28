using Microsoft.EntityFrameworkCore;
using WebAppSat.Models;

namespace WebAppSat
{
    public class ProductService : IProduct
    {
        private readonly ProContext _context;

        public ProductService(ProContext context)
        {
            _context = context;
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            await _context.products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        // ✅ Delete Product
        public async Task<Product?> DeleteProductAsync(int id)
        {
            var product = await _context.products.FindAsync(id);

            if (product == null)
                return null;

            _context.products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

    
        public async Task<List<Product>> GetAllProductsAsync(int pageNumber, int pageSize)
        {
            return await _context.products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

    
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.products.FindAsync(id);
        }

   
        public async Task<Product?> UpdateProductAsync(Product product)
        {
            var existing = await _context.products.FindAsync(product.Id);

            if (existing == null)
                return null;

            existing.Name = product.Name;
            existing.Price = product.Price;
            existing.Category = product.Category;

            await _context.SaveChangesAsync();

            return existing;
        }
    }
}