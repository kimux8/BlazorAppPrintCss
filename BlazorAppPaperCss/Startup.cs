using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

using BlazorAppPaperCss.Shared;

namespace BlazorAppPaperCss
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<PrintSetting>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
