using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitEx1Vs2015.Startup))]
namespace GitEx1Vs2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
