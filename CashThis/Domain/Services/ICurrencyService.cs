using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashThis.Domain.Models;

namespace CashThis.Domain.Services
{
    public interface ICurrencyService
    {
        Task<IEnumerable<Currency>> ListAsync();
    }
}
