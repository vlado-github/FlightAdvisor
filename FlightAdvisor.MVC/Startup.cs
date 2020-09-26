using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlightAdvisor.MVC.Startup))]
namespace FlightAdvisor.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
