using Mapster.Entity.Entity;
using Mapster.Entity.Enum;
using Mapster.Repository.InputModel;
using Mapster.Repository.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Service
{
    public class FuncionarioService : IFuncionarioService
    {
        //Adiciona um funcionario usando as regras do mapeamento em MapsterConfig.
        public Funcionario add(FuncionarioInputModel model)
        {
            var funcionario = model.Adapt<Funcionario>();
            return funcionario;
        }

        public FuncionarioViewModel GetById(Guid id)
        {
            var funcionario = new Funcionario("Tarcisio", "Oliveira", TipoFuncionario.Estagiario );
            var funcionarioViewModel = funcionario.Adapt<FuncionarioViewModel>();

            return funcionarioViewModel;
        }
    }
}
