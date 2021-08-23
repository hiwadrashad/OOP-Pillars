using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Factories;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using WeekOpdrachtDependencyInjection.Business.Strategy;
using WeekOpdrachtDependencyInjection.DataBase;
using WeekOpdrachtDependencyInjection.Repositories;

namespace WeekOpdrachtDependencyInjection
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
            //services.AddSingleton<ICalculatePiService, CalculatePiService>();
            services.AddControllers();
            services.AddMvc();
            services.AddDbContext<MoviesDataBase>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<ICalculateAddingService, CalculatePiService>();
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<IPoultryFactory<IDuckDTO>,PoultryFactory<IDuckDTO>>();
            services.AddTransient<IPoultryFactory<IGooseDTO>, PoultryFactory<IGooseDTO>>();
            services.AddTransient<IPoultryFactory<IChickenDTO>, PoultryFactory<IChickenDTO>>();
            services.AddTransient<IPiStrategy, PiStrategy>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WeekOpdrachtDependencyInjection", Version = "v1" }); c.EnableAnnotations();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "WeekOpdrachtDependencyInjection v1"); c.RoutePrefix = "swagger"; }) ;
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // endpoints for Swagger turned off

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=MoviePage}/{action=FormPage}");
            });
        }
    }
}
