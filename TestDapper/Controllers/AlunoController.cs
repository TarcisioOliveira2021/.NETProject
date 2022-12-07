using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using TestDapper.Entity.Entities;
using TestDapper.Repository.Context;

namespace TestDapper.Controllers
{
    [ApiController]
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly TestDapperDbContext _context;
        private readonly string _connectionString;

        public AlunoController(TestDapperDbContext context, IConfiguration config)
        {
            _context = context;
            _connectionString = config.GetConnectionString("TestDapperBD");
        }


        //Uso do Dapper para retornar todos os alunos
        [HttpGet]
        public async Task<IActionResult> ListAll()
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM tb_alunos";
                var dapper = await sqlConnection.QueryAsync<Aluno>(sql);

                return Ok(dapper);
            }
        }

        //Uso do Dapper inserir um aluno.
        #warning Não sei se está funcionando.
        [HttpPost]
        public async Task<IActionResult> Create(Aluno aluno)
        {
            var dapper = new Aluno(aluno.Id, aluno.Name);

            var dapperParameters = new
            {
                Id = aluno.Id,
                Name = aluno.Name,
            };

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                const string sql = @"INSERT INTO tb_alunos OUTPUT INSERED.Id VALUES (@Id,@Name)";
                var dapperResult = await sqlConnection.ExecuteScalarAsync<int>(sql,dapperParameters);

                return Ok(dapperResult);
            }
        }
    }
}
