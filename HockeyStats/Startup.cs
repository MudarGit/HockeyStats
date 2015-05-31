using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HockeyStats.Startup))]
namespace HockeyStats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
