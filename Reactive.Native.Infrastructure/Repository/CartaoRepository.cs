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
    public class CartaoRepository : ICartaoRepository
    {

        private readonly DotzContext _db;

        public CartaoRepository(DotzContext db)
        {
            this._db = db;
        }

        public async Task<IEnumerable<Cartao>> GetAll()
        {
            try
            {
                var model = await _db.Cartao.AsQueryable().ToListAsync();

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
}
