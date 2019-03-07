using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CashThis.Resources
{
    public class CurrencyConversionResource
    {
        [Required]
        [MaxLength(30)]
        public string OriginCurrencyInThreeLetterFormat { get; set; }

        [Required]
        [MaxLength(30)]
        public string DestinationCurrencyInThreeLetterFormat { get; set; }

        [Required]
        public decimal AmountToConvert { get; set; }
    }
}
