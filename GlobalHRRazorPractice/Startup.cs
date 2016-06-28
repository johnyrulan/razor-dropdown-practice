using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlobalHRRazorPractice.Startup))]
namespace GlobalHRRazorPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
