using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(imranwebapp.Startup))]
namespace imranwebapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
