using banco;
using System;
namespace banco.tests;

public class BankAccountTest
{
   
    [Fact(DisplayName ="Teste de debito")]
    public void AtualizandoBalanco_DebitoValido()
    {
        double balancoAtual = 1000.00;
        double debito = 500.00;
        double balncoExperado = 500.00;
        BankAccount acc1 = new BankAccount("Tarcisio", balancoAtual);

        acc1.Debit(debito);

        double balancoAtualAtt = acc1.Balance;
        Assert.Equal(balncoExperado, balancoAtualAtt);
    }

    [Fact(DisplayName ="Teste para levantamento de exception quando o debito é menor que 0.")]
    public void Debito_menor_zero()
    {
        // Arrange
        double balancoAtual = 10.00;
        double debito = -100.00;
        BankAccount acc2 = new BankAccount("Magneto", balancoAtual);

        // Act and assert
        Assert.Throws<ArgumentOutOfRangeException>(() => acc2.Debit(debito));
    }

    [Fact(DisplayName = "Teste para compara se a mensagem do exception é a esperada.")]
    public void Debito_menor_exception()
    {

        double balancoAtual = 10.00;
        double debito = -100.00;
        BankAccount acc2 = new BankAccount("Magneto", balancoAtual);

        try
        {
            acc2.Debit(debito);
        }
        catch (ArgumentOutOfRangeException e)
        {
            //Como comparar se a mensage é igual a armazenada na variavel ?
            //Teste complicou preciso tirar duvidas de como compara o valor exato da mensagem da exception.

            string msgEsperada = "O debito é menor que 0 (Parameter 'amount')\r\nActual value was -100.";

            Assert.Equal(msgEsperada, e.Message);
        }
    }
}