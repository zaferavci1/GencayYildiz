using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            /*
             * Bu uygulamada kullanılacak servislerin eklendiği/konfigure edilidiği metottur.
             * SERVICE?
             */
            // Belirli işlere odaklanmış ve o işin sorumluluğunu üstlenmiş kütüphaneler/sınıflar.
            //      servis = modül/kütüphane
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*
             * Bu metotta da uygulamada kullanılacak middleware/ara katmanları/ara yazılımları çağıracağız
             */
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
