using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodApp2.Startup))]
namespace FoodApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
