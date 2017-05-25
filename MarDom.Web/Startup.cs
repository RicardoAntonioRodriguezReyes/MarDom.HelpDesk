using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarDom.Web.Startup))]
namespace MarDom.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
