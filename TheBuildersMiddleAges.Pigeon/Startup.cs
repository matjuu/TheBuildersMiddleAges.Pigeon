using Microsoft.Owin.Cors;
using Owin;

namespace TheBuildersMiddleAges.Pigeon
{
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
}