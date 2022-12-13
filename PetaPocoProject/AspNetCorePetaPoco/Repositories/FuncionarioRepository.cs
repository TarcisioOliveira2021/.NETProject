

using AspNetCorePetaPoco.Models;

namespace AspNetCorePetaPoco.Repositories
{
    public class FuncionarioRepository : AbstractRepository<Funcionario>
    {
        public FuncionarioRepository(IConfiguration configuration): base(configuration){}

        public override void Add(Funcionario item)
        {
            Db.Insert(item); //Vai ser gerada com base na classe AbstractRepository.
        }

        public override void Remove(int id)
        {
            var funcionario = Db.Single<Funcionario>(id);
            Db.Delete(funcionario);
        }

        public override void Update(Funcionario item)
        {
           Db.Update(item);
        }

        public override Funcionario FindById(int id)
        {
            return Db.Single<Funcionario>(id);
        }

        public override IEnumerable<Funcionario> FindAll()
        {
            return Db.Query<Funcionario>("SELECT * FROM Funcionarios"); //Quando não consegue precisamos passar a consulta SQL.
        }

    }

}