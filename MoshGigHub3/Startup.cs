using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoshGigHub3.Startup))]
namespace MoshGigHub3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
