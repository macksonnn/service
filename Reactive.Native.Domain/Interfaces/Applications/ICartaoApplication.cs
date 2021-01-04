using Reactive.Native.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactive.Native.Domain.Interfaces.Applications
{
    public interface ICartaoApplication
    {
        Task<IEnumerable<Cartao>> GetAll();
    }
}
