namespace ASP.NET_Core_Web_API_ver2.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();
            if (context.Product.Any) 
            {
                return;
            }
            var 
        }
    }
}
