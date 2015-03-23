using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalReply.Events.Web.Startup))]
namespace CalReply.Events.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
