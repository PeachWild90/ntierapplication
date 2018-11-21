using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpaceShips.Startup))]
namespace SpaceShips
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
