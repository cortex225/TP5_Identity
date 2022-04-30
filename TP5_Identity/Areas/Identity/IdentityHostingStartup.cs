using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(TP5_Identity.Areas.Identity.IdentityHostingStartup))]
namespace TP5_Identity.Areas.Identity
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