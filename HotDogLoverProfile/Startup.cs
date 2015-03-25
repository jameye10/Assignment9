using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotDogLoverProfile.Startup))]
namespace HotDogLoverProfile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
