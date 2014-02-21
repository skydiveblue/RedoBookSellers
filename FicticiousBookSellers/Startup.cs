using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FicticiousBookSellers.Startup))]
namespace FicticiousBookSellers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
