namespace MeuProjetoTeste;

public class UnitTest1
{
    private cpf;
    
    public void SetupTest()
    {
        cpf = "111.111.111-42";
    }


    
    //Passa
    [Fact(DisplayName ="Teste de estrutura AAA")]
    public void TesteEstruturaAAA()
    {
        //Arrange - Preparo
        string cpf = "111.111.111-42";
        var espected = false;
        //Act     - Agir
        var result = ValidadorCpf(cpf);
        //Assert  - Verificar
        Assert.Equal(espected, result);
    }

    //Passa
    [Fact(DisplayName ="Teste de estrutura SEVT")]
    public void TesteEstruturaSEVT()
    {
        //Setup        - Preparo
        SetupTest();
        var espected = false;
        //Exercise     - Agir
        var result = ValidadorCpf(cpf);
        //Verify       - Verificar
        Assert.Equal(espected, result);
        //Teardown     - Destruir/limpar
        cpf = null;
        
    }

    public Boolean ValidadorCpf(string cpf)
    {
        if(cpf != null)
        {
            var ultimoDig  = cpf.Length - 1;
            return ultimoDig != 7 ? false : true; //Se for diferente de 7 então "cpf errado".
        } 
        return true;
    }
    
}
