using Reactive.Native.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactive.Native.Domain.Interfaces.Applications
{
    public interface ISaldoApplication
    {
        Task<Saldo> GetSaldo();
        Task<IEnumerable<Saldo>> GetExtrato();
    }
}
