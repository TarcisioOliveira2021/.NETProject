using AutoFixture;
using Calculo.test.CustomDummie;
using Xunit.Abstractions;

namespace Calculo.test;

public class SomaInputModelTest
{
    private readonly Fixture fixture = new Fixture();
    

    //[Fact(DisplayName = "Testando se o SomaInputModel está vazio.")]
    [Fact]
    public void ValidarChamadaInputModel_True()
    {
        var inputModel = fixture.Create<SomaInputModel>(); //Vai gerar dados falsos para testar.
        Assert.NotNull(inputModel);
    }

    [Fact]
    public void ValidarTipoInputModel(){
        var inputModel = fixture.Create<SomaInputModel>();
        Assert.IsType<int>(inputModel.operador1);
    }

    [Fact]
    public void ValidarChamadaInputModelCustomizado_True()
    {
        var inputModel = CustomFixture.AddSomaInputModel();
        Assert.NotNull(inputModel);
    }
    
}