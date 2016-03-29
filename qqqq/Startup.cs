using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(qqqq.Startup))]
namespace qqqq
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
