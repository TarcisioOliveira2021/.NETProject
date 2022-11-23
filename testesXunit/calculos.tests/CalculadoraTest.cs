using calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculos.tests
{
    public class CalculadoraTest
    {
        public static readonly Calculadora c = new Calculadora();

        [Fact(DisplayName ="Testando soma dos valores")]
        public void RetornoSoma()
        {
            var result = c.Soma(4, 5);
            Assert.Equal(9, result);
        }

        //Teste parametrizado
        [Theory]
        [InlineData(1)]  
        [InlineData(2)]  
        [InlineData(3)]  
        [InlineData(4)]  
        [InlineData(5)]  //Falha
        public void RestoDivisao(int x)
        {
            var result = c.RestoDivisao(12, x);
            Assert.Equal(0, result.resto);
        }

        [Fact]
        [Trait("Calculo", "Teste subtração")]
        public void RetornoSubtra()
        {
            var result = c.Subtracao(5, 4);
            Assert.Equal(1, result);
        }

        //Falha
        [Fact]
        [Trait("Calculo", "Teste multiplicação")]
        public void RetornoMult()
        {
            var result = c.Multiplicao(3, 1);
            Assert.Equal(0, result); 
        }

        [Fact]
        public void TestMaior()
        {
            var result = c.Maior(6, 5);
            Assert.True(result);
        }

        //Falha
        [Fact]
        public void TestMaior2()
        {
            //Arrange - Act
            var result = c.Maior(5, 6);
            //Asset
            Assert.True(result);
        }

        //Pula esse teste
        [Fact(Skip ="Exemplo de skip de test")]
        public void TestMaior3()
        {
            var result = c.Maior(7, 6);
            Assert.True(result);
        }
    }
}
