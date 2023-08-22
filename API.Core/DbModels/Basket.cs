using System;
using System.Collections.Generic;
using System.Text;

namespace API.Core.DbModels
{
    class Basket
    {
        public Basket()
        {

        }

        public Basket(string id)
        {

        }

        public string Id { get; set; }

        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}
