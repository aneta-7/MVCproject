using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Samoloty.Startup))]
namespace Samoloty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
