using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lydanghuy_lab456.Startup))]
namespace Lydanghuy_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
