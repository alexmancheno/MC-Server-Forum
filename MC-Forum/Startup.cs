using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MC_Forum.Startup))]
namespace MC_Forum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
