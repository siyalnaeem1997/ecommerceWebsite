using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ecommerceWebsite.Web.Startup))]
namespace ecommerceWebsite.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
