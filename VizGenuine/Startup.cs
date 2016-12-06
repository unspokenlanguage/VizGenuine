using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VizGenuine.Startup))]
namespace VizGenuine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
