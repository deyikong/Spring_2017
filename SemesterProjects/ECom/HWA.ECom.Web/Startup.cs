using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HWA.ECom.Web.Startup))]
namespace HWA.ECom.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
