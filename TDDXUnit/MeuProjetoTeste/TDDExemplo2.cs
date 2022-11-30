using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace MeuProjetoTeste
{
    public class TDDExemplo2
    {

        //Teste Falha
        [Theory(DisplayName = "Testa uma masssa de dados vinda de um método.")]
        [MemberData(nameof(UserList))] //Lista de uma lista
        public void UsersTemConteudoMethod(User user)
        {
            Assert.NotNull(user.Nome); //Teste se o nome == null.
            Assert.IsType<User>(user); //Testa se a lista vinda é do tipo User.

        }

        //Lista passada para o teste.
        public static IEnumerable<object[]> UserList => new[]
        {
            new [] { new User {Nome = "Test" , Idade = 10}},
            new [] { new User {Nome = "Test" , Idade = 10}},
            new [] { new User {Idade = 10}} //Falha pois Nome == null.
        };


        //Teste Falha
        [Theory(DisplayName = "Testa uma masssa de dados vindos de uma classe.")]
        [ClassData(typeof(UserListData))] 
        public void UsersTemConteudoClass(User user)
        {
            Assert.NotNull(user.Nome); 
            Assert.IsType<User>(user);
        }

        //Classe passada para o teste
        public class UserListData : IEnumerable<object[]> 
        {
            private readonly List<object[]> _dadosList = new List<object[]>
            {
                new [] { new User { Nome = "Test2", Idade = 40 }}, //Passa
                new [] { new User { Nome = "Test2", Idade = 40 }}, //Passa
                new [] { new User { Idade = 90 }} //Falha
            };

            public IEnumerator<object[]> GetEnumerator() => _dadosList.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

    }
}
