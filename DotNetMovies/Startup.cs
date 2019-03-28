using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetMovies.Startup))]
namespace DotNetMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
