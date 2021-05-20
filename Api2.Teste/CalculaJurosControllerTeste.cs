using Api2.Controllers;
using Api2.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api2.Teste
{
    public class CalculaJurosControllerTeste
    {
        private readonly JurosServicos _jurosServicos;
        public CalculaJurosControllerTeste()
        {
            _jurosServicos = new JurosServicos(new HttpClient());
        }

        [Fact]
        public async Task CalculaJuros_Sucesso()
        {
            //arrange
            var valorInicial = 100;
            var meses = 5;

            var calculaJuroscontroller =
                new CalculaJurosController(_jurosServicos);

            //act
            var valorFinal = await calculaJuroscontroller.CalculaJuros(valorInicial, meses);

            //assert
            Assert.True(valorFinal == "105,10");


        }
    }
}
