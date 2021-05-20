using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api2.Servicos
{
    public class JurosServicos: BaseHttpServicos, IJurosServicos
    {
        private HttpClient httpClient;

        class Api1Uris
        {
            public static string Base => "https://localhost:44352/";
            public static string BuscaTaxaJuros => "api1/juros/taxaJuros";
        }

        public JurosServicos(HttpClient httpCliente) : base( httpCliente)
        {
            _baseUri = Api1Uris.Base;
        }

        public async Task<decimal> BuscaTaxaJuros()
        {
            var uri = Api1Uris.Base + Api1Uris.BuscaTaxaJuros;
            var retorno = await GetAsync<decimal>(uri);
            return retorno;
        }
    }
}
