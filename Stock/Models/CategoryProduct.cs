using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Models
{
    public class CategoryProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public CategoryProduct()
        {
        }

        public CategoryProduct(int _id, string _name )
        {
            Id = _id;
            Name = _name;
            Products = new List<Product>();
        }
    }
}
