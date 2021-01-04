using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Reactive.Native.Application.ServiceApplication;
using Reactive.Native.Domain.Interfaces.Applications;
using Reactive.Native.Domain.Interfaces.Repositories;
using Reactive.Native.Domain.Interfaces.Services;
using Reactive.Native.Domain.Services;
using Reactive.Native.Infrastructure.Context;
using Reactive.Native.Infrastructure.Repository;
using Reactive.Native.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reactive.Native.Web
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

            services.AddControllers();
            services.AddScoped<ISaldoApplication, SaldoApplication>();
            services.AddScoped<ISaldoService, SaldoService>();
            services.AddScoped<ISaldoRepository, SaldoRepository>();
            services.AddScoped<ICartaoApplication, CartaoApplication>();
            services.AddScoped<ICartaoService, CartaoService>();
            services.AddScoped<ICartaoRepository, CartaoRepository>();


            //services.AddAuthorization();
            services.AddCors();

            var connection = Configuration["ConexaoMySql:MySqlConnectionString"];
            services.AddDbContext<DotzContext>(options =>
                options.UseMySql(connection)
            );


            services.AddCors(options =>
             options.AddPolicy("MyPolicy",
                 builder =>
                 {
                     builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                 }
             )
         );
            //'MvcOptions.EnableEndpointRouting = false'
            services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

        

            app.UseRouting();

            //app.UseAuthorization();
            //app.UseCors(option => option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseCors("MyPolicy");
 



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
