using System;
using System.Collections.Generic;
using System.Text;

namespace API.Core.DbModels
{
    class BasketItem:BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

        public string ProductType { get; set; }

        public string ProductBrand { get; set; }
    }
}
