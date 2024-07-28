using Dashboard1.Models;
using Microsoft.EntityFrameworkCore;

namespace Dashboard1.Data
{
            public class ApplicationDbContext : DbContext
        {

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


            public DbSet<Products> products { get; set; }

            public DbSet<ProductsDetails> productsDetails { get; set; }

            public DbSet<Damegedproducts> damegedproducts { get; set; }
        public object dameg { get; internal set; }
    }
    }


