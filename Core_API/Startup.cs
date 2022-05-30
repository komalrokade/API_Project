using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_API.Models;
using Core_API.Models.Sevices;
using Microsoft.EntityFrameworkCore;

namespace Core_API
{
    public class Startup
    {
        /// <summary>
        /// Injected with the ICLonfiguration Interce
        /// This is used to read configuraion settings from appsetting.json file
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        /// <summary>
        /// The method for DIContainerm used to reister all dependencies using
        /// IServieceColection Intefcace
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CompanyContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AppConnStr"));
            });

            //Register the custom services
            //Interface name and the class that iplemetns the interface

            services.AddScoped<IDBService<Department, int>, DepartmetDBService>();

            //Method that informs the HOST that the current application is for API
            services.AddControllers();
            //genrate the API documentation
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Core_API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// IApplicationBuilder : use to configure middlewares in the HTTP Request Pipeline
        /// IWebHostEnvironment : specify that if the current project is executed in developmet mode or production mode
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Core_API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
