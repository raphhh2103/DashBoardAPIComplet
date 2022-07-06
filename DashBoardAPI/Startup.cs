using DashBoardAPI.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using UserRepository = DashBoardDAL.Repositories.UserRepository;
using UserService = BLL.Services.UserService;
using TeamRepository = DashBoardDAL.Repositories.TeamRepository;
using TeamService = BLL.Services.TeamService;
using ContentRepository = DashBoardDAL.Repositories.ContentRepository;
using ContentService = BLL.Services.ContentService;
using BoardRepository = DashBoardDAL.Repositories.BoardRepository;
using BoardService = BLL.Services.BoardService;
using ProjectRepository = DashBoardDAL.Repositories.ProjectRepository;
using ProjectService = BLL.Services.ProjectService;

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
            services.AddTransient(typeof(UserRepository));
            services.AddTransient(typeof(UserService));
            services.AddTransient(typeof(TeamRepository));
            services.AddTransient(typeof(TeamService));
            services.AddTransient(typeof(ContentRepository));
            services.AddTransient(typeof(ContentService));
            services.AddTransient(typeof(BoardRepository));
            services.AddTransient(typeof(BoardService));
            services.AddTransient(typeof(ProjectRepository));
            services.AddTransient(typeof(ProjectService));

            services.AddControllers();
            
            //var builder = 
            //string tokenKey = services.Configuration["jwt:key"];

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
            app.UseStaticFiles();
            

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
