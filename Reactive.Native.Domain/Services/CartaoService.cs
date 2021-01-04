using Reactive.Native.Domain.Entities;
using Reactive.Native.Domain.Interfaces;
using Reactive.Native.Domain.Interfaces.Repositories;
using Reactive.Native.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactive.Native.Domain.Services
{
    public class CartaoService : ICartaoService
    {
        private readonly ICartaoRepository _cartaoRepository;
        public CartaoService(ICartaoRepository cartaoRepository)
        {
            this._cartaoRepository = cartaoRepository;
        }

        public async Task<IEnumerable<Cartao>> GetAll()
        {
            var model = await _cartaoRepository.GetAll();
            return model;
        }

       
    }
}
