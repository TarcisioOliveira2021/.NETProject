using PetaPoco;

//Classe Usando as annotations do petapoco.
namespace AspNetCorePetaPoco.Models
{
    [TableName("Funcionarios")]
    [PrimaryKey("Id", AutoIncrement = false)]
    public class Funcionario
    {
        [Column(Name = "id")]
        public Guid Id { get; set; }

        [Column(Name = "nome")]
        public String NomeCompleto { get; set; }

        [Column(Name = "idade")]
        public int Idade { get; set; }
        
        public Funcionario(Guid id, string nomeCompleto, int idade)
        {
            Id = Guid.NewGuid();
            NomeCompleto = nomeCompleto;
            Idade = idade;
        }
    }
}