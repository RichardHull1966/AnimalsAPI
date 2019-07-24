using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using AnimalsAPI.Persistence.Contexts;
using AnimalsAPI.Services;
using AnimalsAPI.Persistence.Repositories;
using AnimalsAPI.Domain.Repositories;
using AnimalsAPI.Domain.Services;
using AutoMapper;

namespace AnimalsAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        [System.Obsolete]
        public void ConfigureServices(IServiceCollection services)
            {
            services
                    .AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<IHamsterRepository, HamsterRepository>();
            services.AddScoped<IHamsterService, HamsterService>();

            services.AddScoped<ICatRepository, CatRepository>();
            services.AddScoped<ICatService, CatService>();

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                    .AllowAnyMethod();
                });
            });
            services.AddAutoMapper();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
        public void Configure(IApplicationBuilder app,
                IHostingEnvironment env)
            {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseMvc();
        }
    }
}
