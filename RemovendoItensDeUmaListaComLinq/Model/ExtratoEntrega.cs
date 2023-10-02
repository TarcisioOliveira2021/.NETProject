using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Model
{
    public class ExtratoEntrega
    {
        public int idPeriodicidade { get; set; }
        public int Periodo { get; set; }

        public ExtratoEntrega(int idPeriodicidade, int periodo)
        {
            this.idPeriodicidade = idPeriodicidade;
            this.Periodo = periodo;
        }
    }
}