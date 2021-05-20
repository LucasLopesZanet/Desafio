using Api2.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api2.Controllers
{
    [Route("api2/calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IJurosServicos _jurosSevicos;

        public CalculaJurosController(IJurosServicos jurosSevicos)
        {
            this._jurosSevicos = jurosSevicos;
        }

        [HttpGet]
        [Route("calculajuros")]
        public async Task<string> CalculaJuros(double valorInicial, int meses)
        {
            var taxaDeJuros = (double)await _jurosSevicos.BuscaTaxaJuros();           

            for (int i = 0; i < meses; i++)
            {
                valorInicial *= taxaDeJuros + 1;
            }
            return valorInicial.ToString("F");

        }
    }
}
