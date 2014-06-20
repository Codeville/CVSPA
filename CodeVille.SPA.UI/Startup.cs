using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeVille.SPA.UI.Startup))]
namespace CodeVille.SPA.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
