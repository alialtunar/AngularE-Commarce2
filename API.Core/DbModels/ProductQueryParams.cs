using System;
using System.Collections.Generic;
using System.Text;

namespace API.Core.DbModels
{
    public class ProductQueryParams
    {
        public string Name { get; set; }

        public decimal MinPrice { get; set; } = 1000;

        public decimal MaxPrice { get; set; } = 1000000;

        public int CategoryId { get; set; }

    }
}
