using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seminaire.Startup))]
namespace Seminaire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
