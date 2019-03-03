using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashThis.Domain.Models;
using CashThis.Domain.Repositories;
using CashThis.Domain.Services;

namespace CashThis.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }
        public async Task<IEnumerable<Currency>> ListAsync()
        {
            return await _currencyRepository.ListAsync();
        }
    }
}
