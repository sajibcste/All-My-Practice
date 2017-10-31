using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HtmlHelper.Startup))]
namespace HtmlHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
