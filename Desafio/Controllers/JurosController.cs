using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api1.Controllers
{
    [Route("api1/juros")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        // GET: api1/juros/taxaJuros
        [HttpGet]
        [Route("taxaJuros")]
        public decimal TaxaDeJuros()
        {
            decimal taxaDeJuros = 0.01m;
            return taxaDeJuros;
        }

        

    }
}
