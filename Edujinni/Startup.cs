using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Edujinni.Startup))]
namespace Edujinni
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
