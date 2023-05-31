using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Pelix.DAL.Context;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelix.Api
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
            //Context
            services.AddDbContext<PelixContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("PelixContext")));

            //Repositories
            services.AddTransient<IPeliculaRepository, PeliculaRepository>();

            //App Services//
            //services.AddTransient<IPeliculaService, DepartmentService>();


            //services.AddTransient<IPeliculaRepository, PeliculaRepository>();
            services.AddTransient<IRentRepository, RentRepository>();
            services.AddTransient<IRolRepository, RolRepository>();
            services.AddTransient<ISaleRepository, SaleRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IGeneroPeliculaRepository, GeneroPeliculaRepository>();
            services.AddTransient<IGeneroRepository, GeneroRepository>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Pelix.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pelix.Api v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
