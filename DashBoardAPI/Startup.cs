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
using JwtBehavior.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using BLL.Services;
using DashBoardDAL.Services;
using DashBoardAPI.Services;

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
            services.AddCors(options =>
            {
                options.AddPolicy("index", b => b.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            });
            JwtSettings BindJwtSettings = new JwtSettings();
            Configuration.Bind("JsonWebTokenKeys", BindJwtSettings);

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
            services.AddTransient(typeof(AccountServiceBll));
            services.AddTransient(typeof(AccountServicesDAL));
            services.AddTransient(typeof(AccountServices));
            services.AddSingleton(BindJwtSettings);
            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = BindJwtSettings.validateIssuerSigningKey,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(BindJwtSettings.IssuerSigningKey)),

                    ValidateIssuer = BindJwtSettings.ValidateIssuer,
                    ValidIssuer = BindJwtSettings.ValidIssuer,
                    ValidateAudience = BindJwtSettings.ValidateAudience,
                    ValidAudience = BindJwtSettings.ValidAudience,
                    RequireExpirationTime = BindJwtSettings.RequireExpirationTime,
                    ValidateLifetime = BindJwtSettings.RequireExpirationTime,
                    ClockSkew = TimeSpan.FromDays(1),
                };
            });
            services.AddControllers();


            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization Header using the Bearer scheme"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement { 
                {
                    new OpenApiSecurityScheme{Reference = new OpenApiReference{Type = ReferenceType.SecurityScheme,Id = "Bearer"} },
                    new string[]{}}
                });

                //c.SwaggerDoc("v1", new OpenApiInfo { Title = "DashBoardAPI", Version = "v1" });
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
            //app.UseStaticFiles();
            //app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("index");
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
