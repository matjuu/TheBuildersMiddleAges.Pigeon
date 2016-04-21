using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace TheBuildersMiddleAges.Pigeon
{
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);

            var hubConfiguration = new HubConfiguration
            {
                EnableDetailedErrors = true,
                EnableJSONP = true
            };

            app.MapSignalR(hubConfiguration);
        }
    }
}