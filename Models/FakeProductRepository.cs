using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanCentral.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product> {
            new Product { Description = "Football", Price = 25 },
            new Product { Description = "Surf Board", Price = 179 },
            new Product { Description = "Running Shoes", Price = 95 }
        };
    }
}