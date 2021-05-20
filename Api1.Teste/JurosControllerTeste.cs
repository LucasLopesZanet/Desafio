using Api1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api1.Teste
{
    public class JurosControllerTeste
    {
        [Fact]
        public void BuscaTaxaJuros_Sucesso()
        {
            //arrange
            var taxaJuros = 0.01m;
            var jurosController = new JurosController();

            //act
            var taxaJurosRetorno = jurosController.TaxaDeJuros();

            //assert
            Assert.True(taxaJurosRetorno == taxaJuros);
        }

    }
}
