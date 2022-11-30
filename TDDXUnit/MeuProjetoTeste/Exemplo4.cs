using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace MeuProjetoTeste
{

    //Classe para testar exception.
    public class Exemplo4
    {
        private readonly ITestOutputHelper _output;
        private string messsage = "A divisão por zero não é aceita.";

        public Exemplo4(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void VerificarMensagemException()
        {
            var execp = Assert.Throws<DivideByZeroException>(() => ThrowAnException());
            Assert.Equal(messsage, execp.Message); //Verifica se a mensagem é igual.
        }


        //Estrutura AAA
        [Fact]
        public void VerificarMensagemExceptionRecord()
        {
            //Arange
            var execp = Record.Exception(() => ThrowAnException());
           
            //Act
            if(!(execp is DivideByZeroException))
            {
                Assert.True(false);
            }

            //Assert
            Assert.Equal(messsage, execp.Message);
        }

        //Método de execption
        private Exception ThrowAnException()
        {
            throw new DivideByZeroException(messsage);
        }

    }
}
