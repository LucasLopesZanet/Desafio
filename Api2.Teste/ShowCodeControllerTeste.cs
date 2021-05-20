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


            //act
            var urlGithub = new ShowCodeController().ShowmeTheCode();
            
            //assert
            Assert.True(urlGithub.ToString() == "");


        }
    }
}
