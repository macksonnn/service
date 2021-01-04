using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactive.Native.Domain.Interfaces.Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reactive.Native.Web.Controllers
{

    public class CartaoController : ControllerBase
    {
        private readonly ICartaoApplication _cartaoApplication;

        public CartaoController(ICartaoApplication cartaoApplication)
        {
            this._cartaoApplication = cartaoApplication;
        }

        [HttpGet("api/[controller]/[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var model = await _cartaoApplication.GetAll();
            return Ok(model);
        }

       
    }
}
