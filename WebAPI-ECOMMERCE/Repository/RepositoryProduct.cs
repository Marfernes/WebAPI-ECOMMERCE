using Microsoft.EntityFrameworkCore;
using WebAPI_ECOMMERCE.Config;
using WebAPI_ECOMMERCE.Entities;

namespace WebAPI_ECOMMERCE.Repository
{
    public class RepositoryProduct : InterfaceProduct
    {
        private readonly ContextBase _context;

        // Recebe o contexto via DI
        public RepositoryProduct(ContextBase context)
        {
            _context = context;
        }

        public async Task Add(ProductModel objeto)
        {
            await _context.Product.AddAsync(objeto);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(ProductModel objeto)
        {
            _context.Product.Remove(objeto);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductModel> GetEntiryById(int id)
        {
            return await _context.Product.FindAsync(id);
        }

        public async Task<List<ProductModel>> List()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task Update(ProductModel objeto)
        {
            _context.Product.Update(objeto);
            await _context.SaveChangesAsync();
        }
    }
}
