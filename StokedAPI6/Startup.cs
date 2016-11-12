using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StokedAPI6.Startup))]
namespace StokedAPI6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
