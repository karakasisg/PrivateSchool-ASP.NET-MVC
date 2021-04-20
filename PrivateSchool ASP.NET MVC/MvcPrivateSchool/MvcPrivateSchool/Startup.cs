using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPrivateSchool.Startup))]
namespace MvcPrivateSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
