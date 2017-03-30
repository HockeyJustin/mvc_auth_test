using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_auth_test.Startup))]
namespace mvc_auth_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
