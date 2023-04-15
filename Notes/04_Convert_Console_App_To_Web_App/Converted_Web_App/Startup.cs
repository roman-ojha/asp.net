using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Converted_Web_App
{
    internal class Startup
    {
        public void ConfigurationServices(IServiceCollection services)
        {
            // this method will contain all the services that this application use
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // this method is use as a middleware into the application

            // If we need to get access to the environment Since we have used 'CreateDefaultBuilder' in 'Program.cs' we can get access to the environments that this application use
            // So to get the current environments we use 'IWebHostEnvironment'

            // First we have to enable routing of the application
            app.UseRouting();

            // Now we have to setup the default route for the application
            app.UseEndpoints(endpoints =>
            {
                // now here we will get the endpoints where we can call 'MapGet', 'MapPost' methods
                // where inside this method we have to define the url patterns
                endpoints.MapGet("/",async context =>
                {
                    // Now here we can response whatever we want
                    await context.Response.WriteAsync("Hello from web");
                });
            });
        }
    }
}
