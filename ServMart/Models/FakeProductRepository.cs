using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServMart.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
        new Product { Name = "Disinfectant Wipes", Price = 5 },
        new Product { Name = "Mop Bucket", Price = 115 },
        new Product { Name = "Six Part Folder", Price = 5 },
        new Product { Name = "Fabuloso", Price = 10 },
        }.AsQueryable<Product>();
    }
}
