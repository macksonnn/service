using Microsoft.Extensions.DependencyInjection;
using Reactive.Native.Application.ServiceApplication;
using Reactive.Native.Domain.Interfaces;
using Reactive.Native.Domain.Interfaces.Applications;
using Reactive.Native.Domain.Interfaces.Services;
using Reactive.Native.Domain.Services;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Text;

namespace Reactive.Native.IoC
{
    public static class DotzIoC
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ISaldoApplication, SaldoApplication>();
            services.AddScoped<ISaldoService, SaldoService>();
            //services.AddScoped<ISaldoRepository, Reactive.Native.>();

            

        }
    }
}