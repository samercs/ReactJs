using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactJs.Startup))]
namespace ReactJs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
