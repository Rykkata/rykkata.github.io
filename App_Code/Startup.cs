using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rykkata.github.io.Startup))]
namespace rykkata.github.io
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
