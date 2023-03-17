using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LamBinhHung_2011063395_BigSchool2.Startup))]
namespace LamBinhHung_2011063395_BigSchool2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
