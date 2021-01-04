using Reactive.Native.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactive.Native.Domain.Interfaces.Services
{
   public interface ISaldoService
    {
        Task<Saldo> GetSaldo();
        Task<IEnumerable<Saldo>> GetExtrato();

    }
}
