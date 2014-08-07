using Microsoft.Owin;
using MvcMovie;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace MvcMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
