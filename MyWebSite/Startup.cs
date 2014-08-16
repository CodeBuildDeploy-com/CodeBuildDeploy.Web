using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebSite.Startup))]
namespace MyWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
