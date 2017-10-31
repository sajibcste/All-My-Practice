using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(introMVC.Startup))]
namespace introMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
