using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMMDataCloud.Startup))]
namespace CMMDataCloud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
