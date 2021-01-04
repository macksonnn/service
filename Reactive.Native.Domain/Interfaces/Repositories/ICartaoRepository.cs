using Reactive.Native.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reactive.Native.Domain.Interfaces.Repositories
{
    public interface ICartaoRepository
    {
        Task<IEnumerable<Cartao>> GetAll();

    }
}
    