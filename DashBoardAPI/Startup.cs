using DashBoardAPI.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
<<<<<<< HEAD
using BllOwnerService = BLL.Services.UserService;
using DalOwnerService = DashBoardDAL.Repositories.UserRepository;
=======
using UserRepository = DashBoardDAL.Repositories.UserRepository;
using UserService = BLL.Services.UserService; 
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0

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

namespace DashBoardAPI
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
            services.AddScoped<IContext>(m => new Context.Context());
<<<<<<< HEAD
            services.AddTransient(typeof(BllOwnerService));
            services.AddTransient(typeof(DalOwnerService));

=======
            services.AddTransient(typeof(UserRepository));
            services.AddTransient(typeof(UserService));
>>>>>>> 9b4b8d11ee1ac5294b585e0a2a82d2e118d303b0

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DashBoardAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DashBoardAPI v1"));
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
