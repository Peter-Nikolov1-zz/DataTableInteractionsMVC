using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataTableInteractions.MVC.Startup))]
namespace DataTableInteractions.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
