using Mapster.Entity.Entity;
using Mapster.Repository.InputModel;
using Mapster.Repository.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Mapster.Repository.MappingMapster
{
    public static class MapsterMapConfig
    {
        public static void RegisterMap(this IServiceCollection service)
        {
            TypeAdapterConfig<Funcionario, FuncionarioViewModel>
                .NewConfig()
                .Map(member => member.NomeCompleto , source => $"{source.PrimeiroNome} {source.UltimoNome}");

            TypeAdapterConfig<FuncionarioInputModel, Funcionario>
                .NewConfig()
                .ConstructUsing(f => new Funcionario(f.PrimeiroNome, f.UltimoNome, f.Tipo));

            TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        }
    }
}
