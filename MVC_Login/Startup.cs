using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Login.Startup))]
namespace MVC_Login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
