using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CubeX.Startup))]
namespace CubeX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
