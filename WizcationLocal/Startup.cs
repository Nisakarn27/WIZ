using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WizcationLocal.Startup))]
namespace WizcationLocal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
