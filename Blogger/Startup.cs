using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Blogger
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Voeg MVC als service toe
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Toont alleen exceptions in de development omgeving
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Maakt gebruik van static pagina's
            app.UseStaticFiles();

            // Route mapping
            app.UseMvc(config =>
            {
                // Route maping
                config.MapRoute(
                    name: "Default", // Route naam
                    template: "{controller}/{action}/{id?}", // pad die getriggered wordt: Home/index/ ( eventueel een id )
                    defaults: new { controller = "Home", Action = "Index" }
                );
            });
        }
    }
}
