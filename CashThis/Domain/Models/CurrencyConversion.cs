using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashThis.Domain.Models
{
    public class CurrencyConversion
    {
        public int Id { get; set; }
        public int OriginalCurrencyId { get; set; }
        public Currency Currency { get; set; }
        public string ConversionName { get; set; }
        public decimal DestinationCurrencyValue { get; set; }
    }
}
