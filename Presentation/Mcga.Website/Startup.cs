using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mcga.Website.Startup))]
namespace Mcga.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
