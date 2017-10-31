using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entity_Framawoek.Startup))]
namespace Entity_Framawoek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
