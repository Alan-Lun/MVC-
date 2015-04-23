using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Work01.Startup))]
namespace MVC_Work01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
