using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreemfinchTest.Services;
using GreemfinchTest.Services.Interfaces;
using GreenfinchTest.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GreenfinchTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<INewsletterService, NewsletterService>();
            services.AddDbContext<NewsletterContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("GreenfinchConnection"))
            );
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Allow CORS for everything, just demo purpouse.
            app.UseCors(b => b.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials());

            app.UseMvc();
        }
    }
}
