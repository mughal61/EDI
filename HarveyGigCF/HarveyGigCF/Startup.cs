using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HarveyGigCF.Startup))]
namespace HarveyGigCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
