using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace MeuProjetoTeste
{
    //Classe para testar o paralelismo do xUnit, execução de multiplos tests.

    //Demora::  6 + 2  = 8segundos para executar.
    public class Exemplo3A
    {
        private readonly ITestOutputHelper _output;

        public Exemplo3A(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TesteLongo()
        {
            _output.WriteLine("Exemplo3A : EXEC -- TestLongo");
            Thread.Sleep(6000); //6Segundos
        }

        [Fact]
        public void TesteCurto()
        {
            _output.WriteLine("Exemplo3A : EXEC -- TestCurto");
            Thread.Sleep(2000); //2Segundos
        }

    }

    //Demora:: 10 + 2 = 12segundos para executar.
    public class Exemplo3B
    {
        private readonly ITestOutputHelper _output;

        public Exemplo3B(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TesteLongo()
        {
            _output.WriteLine("Exemplo3B : EXEC -- TestLongo");
            Thread.Sleep(10000); //10Segundos
        }

        [Fact]
        public void TesteCurto()
        {
            _output.WriteLine("Exemplo3B : EXEC -- TestCurto");
            Thread.Sleep(2000); //2Segundos
        }
    }


    //Demora:: 14 + 17 = 31segundos para executar.
    [Collection("Colecao")]
    //Demora::  = 14segundos para executar. --Vai ser serializado
    public class Exemplo3C
    {
        private readonly ITestOutputHelper _output;

        public Exemplo3C(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TesteLongo()
        {
            _output.WriteLine("Exemplo3C : EXEC -- TestLongo");
            Thread.Sleep(14000); //14Segundos
        }

    }

    //Demora:: 14 + 17 = 31segundos para executar
    [Collection("Colecao")]
    //Demora::  = 17segundos para executar. --Vai ser serializado
    public class Exemplo3D
    {
        private readonly ITestOutputHelper _output;

        public Exemplo3D(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TesteLongo()
        {
            _output.WriteLine("Exemplo3D : EXEC -- TestLongo");
            Thread.Sleep(17000); //17Segundos
        }

    }
}
