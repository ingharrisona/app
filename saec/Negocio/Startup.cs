using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Negocio.Startup))]
namespace Negocio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
