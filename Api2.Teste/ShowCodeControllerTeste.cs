using Api2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api2.Teste
{
    public class ShowCodeControllerTeste
    {
        [Fact]
        public void CalculaJuros_Sucesso()
        {
            //arrange
            var urlGithub = "https://github.com/LucasLopesZanet/Desafio";


            //act
            var urlGithubRetorno = new ShowCodeController().ShowmeTheCode().Result;
            
            //assert
            Assert.True(urlGithubRetorno == urlGithub);


        }
    }
}
