using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api2.Servicos
{
    public interface IJurosServicos
    {
        public  Task<decimal> BuscaTaxaJuros();
    }
}
