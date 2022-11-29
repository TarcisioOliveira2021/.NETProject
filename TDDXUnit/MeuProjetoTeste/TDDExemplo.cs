using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace MeuProjetoTeste
{
    public class TDDExemplo
    {

        //Para testar o logger do test.
        ITestOutputHelper _output;
        public void Exemplo1(ITestOutputHelper output)
        {
            _output = output;
        }

        //Para rodar um teste especifico == dotnet test --filter NomeDaCatergoria = NomeGrupo
        //O esperado é que passe
        [Fact(DisplayName = "Testa se é maior de idade")]
        [Trait("TesteUnit", "Test01")]
        public void TesteIdadeMaior18()
        {
            //Arrange
            User user = new User("Tarcisio", 20);
            //Act
            var result = user.ValidaIdade();
            //Assert
            Assert.True(result);
        }

        [Fact(DisplayName = "Testa se é maior de idade segunda forma")]
        [Trait("TesteUnit", "Test02")]
        public void TesteIdadeMaior182()
        {
            //Arrange
            User user = new User("Tarcisio", 20);
            var expect = true;
            //Act
            var result = user.ValidaIdade();
            //Assert
            Assert.Equal(expect, result);
        }

        //O esperado é que falhe.
        [Fact(DisplayName ="Testa se é menor de idade")]
        [Trait("TesteUnit", "Test03")]
        public void TesteIdadeMenor18()
        {
            //Arrange
            User user = new User("XPTO", 16);
            //Act
            var result = user.ValidaIdade();
            //Assert
            Assert.True(result);
        }

        //Teste parametrizados
        [Theory(DisplayName ="Teste parametrizado")]
        [Trait("TesteParam","Test01")]
        [InlineData(12)] //Falha
        [InlineData(22)] //Passa
        [InlineData(70)] //Passa
        public void TesteParametrizado(int idade)
        {
            //Arrange
            User user = new User("TEST", idade);
            //Act
            var result = user.ValidaIdade();
            //Assert
            Assert.True(result);
        }

        [Fact(Skip ="Não implementado")]
        [Trait("TestUnit","Test04")]
        public void TesteNImplementado()
        {
            //TODO:   Precisa implementar
            //HACK:   Precisa implementar
            //UNDONE: Precisa implementar
        }
    }
}
