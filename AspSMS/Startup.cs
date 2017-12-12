using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspSMS.Startup))]
namespace AspSMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
