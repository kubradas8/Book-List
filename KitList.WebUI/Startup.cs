using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitList.Business.Abstract;
using KitList.Business.Concrete;
using KitList.DataAccess.Abstract;
using KitList.DataAccess.Concrete.EntityFramework;
using KitList.WebUI.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace KitList.WebUI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBookService, BookManager>();
            services.AddScoped<IBookDal, EfBookDal>();

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

          app.UseFileServer();
          app.UseNodeModules(env.ContentRootPath);
          app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Book}/{action=Index}/{id?}");
        }
    }
}
