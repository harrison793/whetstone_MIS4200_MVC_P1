using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(whetstone_MIS4200_MVC_P1.Startup))]
namespace whetstone_MIS4200_MVC_P1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
