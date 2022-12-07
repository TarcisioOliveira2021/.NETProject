using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster.Entity.Enum;

namespace Mapster.Repository.InputModel
{
    public class FuncionarioInputModel
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public TipoFuncionario Tipo { get; set; }
        public DateTime nascimento { get; set; }
    }
}
