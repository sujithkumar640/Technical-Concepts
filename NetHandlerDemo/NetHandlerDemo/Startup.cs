using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetHandlerDemo.Startup))]
namespace NetHandlerDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
