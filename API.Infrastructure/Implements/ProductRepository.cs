using API.Core.DbModels;
using API.Core.Interfaces;
using API.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Infrastructure.Implements
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context):base(context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Product>> GetProductsWithIncludes(ProductQueryParams productParams)
        {
           return await _context.Products
                .Include(p=>p.ProductBrand)
                .Include(p=>p.ProductType)
                .ToListAsync();

        }

        public async Task<Product> GetProductWithIncludesById(int id)
        {
            return await _context.Products
                .Include(p => p.ProductBrand)
                .Include(p => p.ProductType)
                .FirstOrDefaultAsync(p => p.Id == id);


        }
    }
}
