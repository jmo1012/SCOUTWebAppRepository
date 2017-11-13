using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScoutWebApp.Startup))]
namespace ScoutWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
