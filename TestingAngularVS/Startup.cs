using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingAngularVS.Startup))]
namespace TestingAngularVS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
