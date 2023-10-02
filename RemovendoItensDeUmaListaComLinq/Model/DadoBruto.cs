using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Model
{
    public class DadoBruto
    {
        public List<ExtratoEntrega> items { get; set; }


        public DadoBruto(List<ExtratoEntrega> items)
        {
            this.items = items;
        }
    }

    
}