using API.Errors;
using API.Infrastructure.DataContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public  ActionResult GetNotFoundRequest()
        {
            var product =  _context.Products.Find(10);

            if (product == null)
            {
                return NotFound(new ApiResponse(404));
            }

            return Ok();
        }
    }
}
