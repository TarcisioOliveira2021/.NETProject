using Mapster.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Entity.Entity
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }
        public TipoFuncionario Tipo { get; set; }

        public Funcionario(string primeiroNome, string ultimoNome, TipoFuncionario tipo)
        {
            Id = Guid.NewGuid();
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Tipo = tipo;
        }
    }
}
