using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashThis.Domain.Models;
using CashThis.Domain.Repositories;
using CashThis.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CashThis.Persistence.Repositories
{
    public class CurrencyRepository:BaseRepository, ICurrencyRepository
    {
        public CurrencyRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Currency>> ListAsync()
        {
            return await _context.Currencies.ToListAsync();
        }
    }
}
