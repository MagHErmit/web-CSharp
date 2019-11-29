using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _3._3_Formula_Map
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Map("/formula", Calc);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Page Not Found");
            });
        }

        static void Calc(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                int x = 4;
                double result = (1 / (4 * Math.Sqrt(3))) * Math.Log((Math.Sqrt(x * x + 2) - (x * Math.Sqrt(3)) / ((Math.Sqrt(x * x + 2) + (x * Math.Sqrt(3))))));
                await context.Response.WriteAsync(result.ToString());
            });
        }
    }
}
