using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LamChauTotTi_2080600714.Startup))]
namespace LamChauTotTi_2080600714
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
