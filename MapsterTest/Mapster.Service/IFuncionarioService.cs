using Mapster.Entity.Entity;
using Mapster.Repository.InputModel;
using Mapster.Repository.ViewModel;

namespace Mapster.Service
{
    public interface IFuncionarioService
    {
        Funcionario add(FuncionarioInputModel model);
        FuncionarioViewModel GetById(Guid id);
    }
}