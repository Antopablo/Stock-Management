using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public int Quantity { get; set; }

        public Product()
        {
        }
        public Product(int _id, string _name, int _categoryId, int _quantity = 0)
        {
            Id = _id;
            Name = _name;
            CategoryId = _categoryId;
            Quantity = _quantity;
        }
    }
}
