using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mcd.Startup))]
namespace mcd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
