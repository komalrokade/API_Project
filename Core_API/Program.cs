using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        /// <summary>
        /// IHostBuilder : THe interface that detect the actual gost for the application(e.g. IIS,APache, 
        /// NGix, Self-Executable) and configure application for
        /// 1.Session State
        /// 2.Cache
        /// 3.Concurrent Requests
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //Load the startup class and instantiate it
                    //Startup class is used for folowing
                    //1.Registering all dependenciea in dependency container
                    //2.Manage the request processing using the middleware
                    //this is used to resolve following interfaces
                    //1.ICongiguraiton
                    //2.IServiceCollection
                    //3.IApplicationBuilder
                    

                    webBuilder.UseStartup<Startup>();
                });
    }
}
