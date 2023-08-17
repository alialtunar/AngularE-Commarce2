using API.Core.DbModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Interfaces
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        Task<IReadOnlyList<Product>> GetProductsWithIncludes(ProductQueryParams productParams);
        Task<Product> GetProductWithIncludesById(int id);
    }
}



