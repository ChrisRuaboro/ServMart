using System.Collections.Generic;
using ServMart.Models;
using ServMart.Models.ViewModels;

namespace ServMart.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}

