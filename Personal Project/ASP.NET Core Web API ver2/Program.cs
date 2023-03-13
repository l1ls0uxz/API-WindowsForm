using MySqlX.XDevAPI.CRUD;
using System.Net.WebSockets;
using ASP.NET_Core_Web_API_ver2.Data;

namespace ASP.NET_Core_Web_API_ver2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ProductContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex) 
                {
                    var logger = services.GetRequiredService<Program>();
                    logger.LogError(ex, "An error occurred seeding the Db.");
                }
            }
            host.Run();
        }
        public static IHostBuilder CreateHostBuider(string[] args)=>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => {  webBuilder.UseStartup<Startup>(); });
    }
}