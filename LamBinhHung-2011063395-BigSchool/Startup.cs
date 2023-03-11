using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LamBinhHung_2011063395_BigSchool.Startup))]
namespace LamBinhHung_2011063395_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
