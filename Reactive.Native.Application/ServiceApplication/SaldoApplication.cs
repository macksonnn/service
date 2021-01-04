using Reactive.Native.Domain.Entities;
using Reactive.Native.Domain.Interfaces.Applications;
using Reactive.Native.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactive.Native.Application.ServiceApplication
{
    public class SaldoApplication : ISaldoApplication
    {

        private readonly ISaldoService _saldoService;
        public SaldoApplication(ISaldoService saldoService)
        {
            this._saldoService = saldoService;
        }

        public async Task<IEnumerable<Saldo>> GetExtrato()
        {
            var model = await _saldoService.GetExtrato();
            return model;
        }

        public async Task<Saldo> GetSaldo()
        {
            var model =  await _saldoService.GetSaldo();
            return model;
        }
    }
}
