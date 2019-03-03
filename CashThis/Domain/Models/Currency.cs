using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashThis.Domain.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public IList<CurrencyConversion> CurrencyConversions { get; set; }
    }
}
