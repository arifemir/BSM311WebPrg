using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(food.Areas.Identity.IdentityHostingStartup))]
namespace food.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}