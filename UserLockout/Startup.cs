using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserLockout.Startup))]
namespace UserLockout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
