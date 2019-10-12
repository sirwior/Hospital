using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hospital.WEB.Startup))]
namespace Hospital.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
