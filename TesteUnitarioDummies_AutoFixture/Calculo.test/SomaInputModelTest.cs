using AutoFixture;
using Calculo.test.CustomDummie;
using Xunit.Abstractions;

namespace Calculo.test;

public class SomaInputModelTest
{
    private readonly Fixture fixture = new Fixture();
    private readonly ITestOutputHelper _output; //vai exibir no console informações.

    public SomaInputModelTest(ITestOutputHelper output)
    {
        _output = output;
    }

    //[Fact(DisplayName = "Testando se o SomaInputModel está vazio.")]
    [Fact]
    public void ValidarChamadaInputModel_True()
    {
        var inputModel = fixture.Create<SomaInputModel>(); //Vai gerar dados falsos para testar.
        Assert.NotNull(inputModel);
    }

    [Fact]
    public void ValidarTipoInputModel()
    {
        var inputModel = fixture.Create<SomaInputModel>();
        Assert.IsType<int>(inputModel.operador1);
    }

    //Usando o Autofixture personalizado como classe externa.
    [Fact]
    public void ValidarChamadaInputModelCustomizado_True()
    {
        var fixture = CustomFixture.AddSomaInputModel();
        var inputModel = fixture.Create<SomaInputModel>();

        _output.WriteLine("Valor do Op1 fixture: "+inputModel.operador1);
        _output.WriteLine("Valor do Op2 fixture: "+inputModel.operador2);

        Assert.NotNull(inputModel);
    }

    //Usando o Autofixture personalizado dentra da classe.
    [Fact]
    public void ValidarChamadaInputModelCustomizado()
    {
        fixture.Customize<SomaInputModel>(
            s =>
            s.With(s => s.operador1, 12)
             .With(s => s.operador2, 90)
        );
        var inputModel = fixture.Create<SomaInputModel>();

        _output.WriteLine("Valor do Op1 fixture: "+inputModel.operador1);
        _output.WriteLine("Valor do Op2 fixture: "+inputModel.operador2);
        
        Assert.NotNull(inputModel);
    }
}