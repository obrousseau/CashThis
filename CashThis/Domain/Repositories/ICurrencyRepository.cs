using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashThis.Domain.Models;

namespace CashThis.Domain.Repositories
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> ListAsync();
    }
}
