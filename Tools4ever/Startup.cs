using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tools4ever.Startup))]
namespace Tools4ever
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
