using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nina_Aulia_Ramadhani_27_XI_RPL_4.Startup))]
namespace Nina_Aulia_Ramadhani_27_XI_RPL_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
