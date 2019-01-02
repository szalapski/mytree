using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyTree.Shared;

namespace MyTree
{  
// it seems that the root namespace must match the folder name, otherwise App won't be found.  See also https://github.com/aspnet/AspNetCore/issues/5524 .

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
