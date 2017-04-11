using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YazilimMuhendisligiProje.Startup))]
namespace YazilimMuhendisligiProje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
