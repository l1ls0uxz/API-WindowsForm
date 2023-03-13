using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_Web_API_ver2.Models;

namespace ASP.NET_Core_Web_API_ver2.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext>options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
