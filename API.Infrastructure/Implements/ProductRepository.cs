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

       

    }
}
