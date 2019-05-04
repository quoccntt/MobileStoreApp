using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobileStore.Web.Startup))]
namespace MobileStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
