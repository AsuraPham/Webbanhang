using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(banhang.Startup))]
namespace banhang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
