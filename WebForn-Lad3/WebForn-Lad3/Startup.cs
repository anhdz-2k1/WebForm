using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForn_Lad3.Startup))]
namespace WebForn_Lad3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
