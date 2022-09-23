using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToyKingdom.Startup))]
namespace ToyKingdom
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
