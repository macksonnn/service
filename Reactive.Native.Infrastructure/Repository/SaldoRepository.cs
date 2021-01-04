using Microsoft.EntityFrameworkCore;
using Reactive.Native.Domain.Entities;
using Reactive.Native.Domain.Interfaces.Repositories;
using Reactive.Native.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reactive.Native.Infrastructure.Repository
{
    public class SaldoRepository : ISaldoRepository
    {

        private readonly DotzContext _db;

        public SaldoRepository(DotzContext db)
        {
            this._db = db;
        }
        
        public async Task<Saldo> GetSaldo()
        {
            try
            {
                var model = _db.Saldo.Find(1);
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Saldo>> GetExtrato()
        {
            try
            {
                var model = await _db.Saldo.AsQueryable().ToListAsync();

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
