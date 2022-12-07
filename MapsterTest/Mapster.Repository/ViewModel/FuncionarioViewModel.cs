using Mapster.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Repository.ViewModel
{
    //Mapeamento de um Funcionario para NomeCompleto.
    public class FuncionarioViewModel
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Nascimento { get; set; }
    }
}
