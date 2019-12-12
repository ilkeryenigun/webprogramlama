using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebProgramlamaProjesi.Startup))]
namespace WebProgramlamaProjesi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
