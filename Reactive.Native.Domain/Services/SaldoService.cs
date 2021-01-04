using Reactive.Native.Domain.Entities;
using Reactive.Native.Domain.Interfaces;
using Reactive.Native.Domain.Interfaces.Repositories;
using Reactive.Native.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactive.Native.Domain.Services
{
    public class SaldoService : ISaldoService
    {
        private readonly ISaldoRepository _saldoRepository;
        public SaldoService(ISaldoRepository saldoRepository)
        {
            this._saldoRepository = saldoRepository;
        }

        public async Task<IEnumerable<Saldo>> GetExtrato()
        {
            var model = _saldoRepository.GetExtrato();
            return model.Result;
        }

        public async Task<Saldo> GetSaldo()
        {
            var model =  _saldoRepository.GetSaldo();
            return model.Result;
        }
    }
}
