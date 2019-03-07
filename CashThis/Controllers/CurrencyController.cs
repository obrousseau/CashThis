using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CashThis.Domain.Models;
using CashThis.Domain.Services;
using CashThis.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CashThis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;
        private readonly IMapper _mapper;

        public CurrencyController(ICurrencyService currencyService, IMapper mapper)
        {
            _currencyService = currencyService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CurrencyResource>> GetAllAsync()
        {
            var currencies = await _currencyService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Currency>, IEnumerable<CurrencyResource>>(currencies);

            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CurrencyConversionResource resource)
        {
            //step 9 - https://medium.freecodecamp.org/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28
        }
    }
}