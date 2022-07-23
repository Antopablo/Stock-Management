using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Models
{
    public class DbContextStock : DbContext
    {
        public DbContextStock(DbContextOptions<DbContextStock> options)
            : base(options)
        {

        }

        public DbSet<CategoryProduct> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
