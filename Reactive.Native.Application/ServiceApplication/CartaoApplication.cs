using Reactive.Native.Domain.Entities;
using Reactive.Native.Domain.Interfaces.Applications;
using Reactive.Native.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reactive.Native.Application.ServiceApplication
{
    public class CartaoApplication : ICartaoApplication
    {
        private readonly ICartaoService _cartaoService;

        public CartaoApplication(ICartaoService cartaoService)
        {
            this._cartaoService = cartaoService;
        }

       
        public async Task<IEnumerable<Cartao>> GetAll()
        {
            var model = await _cartaoService.GetAll();
            return model;
        }
    }
}
