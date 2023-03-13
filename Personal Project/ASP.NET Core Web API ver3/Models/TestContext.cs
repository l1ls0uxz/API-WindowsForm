using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Web_API_ver3.Models
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            :base(options)
        { }
        public DbSet<Test> Tests { get; set; } = null!;
    }
}
