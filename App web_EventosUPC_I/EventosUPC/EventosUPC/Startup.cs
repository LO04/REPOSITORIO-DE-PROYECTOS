using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventosUPC.Startup))]
namespace EventosUPC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
