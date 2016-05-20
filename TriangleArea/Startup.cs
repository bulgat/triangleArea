using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TriangleArea.Startup))]
namespace TriangleArea
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
