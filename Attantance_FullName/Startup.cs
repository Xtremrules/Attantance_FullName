using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Attantance_FullName.Startup))]
namespace Attantance_FullName
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
