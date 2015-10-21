using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Eshop.Startup))]

namespace Eshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
