using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular_MVC_Bank.Startup))]
namespace Angular_MVC_Bank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
