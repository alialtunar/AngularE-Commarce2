using API.Core.DbModels;
using API.Core.Interfaces;
using API.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
  
    public class ProductsController : BaseApiController
    {

        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public ProductsController(IProductRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductToReturnDto>>> GetProducts()
        {
            var data = await _repository.GetProductsWithIncludes();

            return Ok(_mapper.Map<IReadOnlyList<Product>,IReadOnlyList<ProductToReturnDto>>(data));
        }


        [HttpGet("{id}")]

        public async Task<ProductToReturnDto> GetProduct(int id)
        {
            var data = await _repository.GetProductWithIncludesById(id);

           

            return _mapper.Map<Product, ProductToReturnDto>(data);
        }



    }
}
