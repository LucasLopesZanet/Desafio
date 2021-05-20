using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api2.Servicos
{
    public abstract class BaseHttpServicos
    {
        protected readonly HttpClient _httpCliente;
        protected string _baseUri;

        public BaseHttpServicos( HttpClient httpCliente)
        {
            _httpCliente = httpCliente;
        }

        protected async Task<T> GetAsync<T>(string uri, params object[] param)
        {
            string requestUri =
                string.Format(new Uri(new Uri(_baseUri), uri).ToString(), param);

            foreach (var par in param)
            {
                requestUri += string.Format($"/{par}");
            }

            var json = await _httpCliente.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
