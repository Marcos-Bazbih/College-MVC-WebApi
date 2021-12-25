using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(College_MVC_WebApi.Startup))]
namespace College_MVC_WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
