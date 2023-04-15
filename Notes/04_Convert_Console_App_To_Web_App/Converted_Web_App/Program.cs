using Converted_Web_App;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System;

namespace ConvertedWebApp
{

    class Program
    {
        // Main is the function that get called when starting the application
        // Also web application can have a program class which will have the 'Main' method
        // and that main method is the entry point for any .NET Core application
        private static void Main(string[] args)
        {
            // We will call the HostBuild while starting of the application
            // Where we can pass some command line arguments as well
            CreateHostBuilder(args).Build().Run();
        }

        // Now we will create the HostBuilder Method
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            // Now here we will create the default build
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                // we can see the functionality this method have from given image in this directory
                // Where this function also add Middleware into the application
                // Setup Middleware now, for that we will create the another class called 'Startup.cs'
                webBuilder.UseStartup<Startup>();
                // Now we have to make some changes in Startup class
            });
        }
    }
}