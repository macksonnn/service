using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reactive.Native.Domain.Interfaces.Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Reactive.Native.Web.Controllers
{

    
    public class SaldoController : ControllerBase
    {
        private readonly ISaldoApplication _saldoApplication;


        public SaldoController(ISaldoApplication saldoApplication)
        {
            this._saldoApplication = saldoApplication;
        }

        [HttpGet("api/[controller]/[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> GetSaldo()
        {
            var model = await _saldoApplication.GetSaldo();
            return Ok(model);
        }

        [HttpGet("api/[controller]/[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> GetExtrato()
        {
            var model = await _saldoApplication.GetExtrato();
            return Ok(model);
        }


    }
}
