using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lad1.Startup))]
namespace Lad1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
