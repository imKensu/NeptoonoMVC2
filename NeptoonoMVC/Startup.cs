using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NeptoonoMVC.Startup))]
namespace NeptoonoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
