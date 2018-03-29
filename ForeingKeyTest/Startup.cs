using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForeingKeyTest.Startup))]
namespace ForeingKeyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
