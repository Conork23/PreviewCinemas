using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreviewCinemas.Startup))]
namespace PreviewCinemas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
