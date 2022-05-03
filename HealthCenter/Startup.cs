
using DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCenter
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var connection =
            Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<HealthyContext>(options =>
            options.UseSqlServer(connection));
            services.AddControllers();
            services.AddMvc(options => options.EnableEndpointRouting = false).AddNewtonsoftJson(options => {
            options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            string[] s = new string[] { "http://localhost:8080", "http://localhost:8081", "http://localhost:5000", "http://localhost:8083", "http://localhost:8084", "http://localhost:8085" };
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowCredentials().WithOrigins(s)
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                        
                    });
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HealthCenter", Version = "v1" });
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HealthCenter"));
            }

            app.UseRouting();
            app.UseAuthorization();

           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });



            //app.Use((context, next) =>
            //{
            //    context.Response.Headers["Access-Control-Allow-Origin"] = "*";
            //    context.Response.Headers["Access-Control-Allow-Headers"] = "Origin, X-Requested-With, Content-Type, Accept";
            //    context.Response.Headers["Access-Control-Allow-Methods"] = "PUT, POST, GET, DELETE, OPTIONS";
            //    return next.Invoke();
            //});
        }
    }
}
