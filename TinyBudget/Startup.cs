using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TinyBudget.Startup))]
namespace TinyBudget
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
