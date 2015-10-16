using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EshopMain.Startup))]

namespace EshopMain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
