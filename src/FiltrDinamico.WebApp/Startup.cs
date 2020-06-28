using FiltrDinamico.Core.DependecyInjection;
using FiltrDinamico.WebApp.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FiltrDinamico.WebApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FiltroDinamicoContext>(options => {
                options.UseSqlServer("Server=192.168.99.100;Database=FiltroDinamico;User=sa;Password=yourStrong(!)Password");
            });
            services.AddMvcCore(options =>
            {
                options.EnableEndpointRouting = false;
            });

            services.AddControllers();
            services.AddFiltroDinamico();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseMvc();
        }
    }
}
