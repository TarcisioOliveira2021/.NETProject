using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace MeuProjetoTeste
{
    public class TDDExemplo2
    {

        //Teste passa
        [Theory(DisplayName = "Testa uma masssa de dados")]
        [MemberData(nameof(UserList))] //Lista de uma lista
        public void UsersTemConteudo(User user)
        {
            Assert.NotNull(user.Nome);
            Assert.IsType<User>(user);
        }

        public static IEnumerable<object[]> UserList => new[]
        {
            new [] { new User {Nome = "Test" , Idade = 10}},
            new [] { new User {Nome = "Test" , Idade = 10}}
        };

    }
}
