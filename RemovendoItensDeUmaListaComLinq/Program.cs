// See https://aka.ms/new-console-template for more information
using Teste.Model;

Console.WriteLine("Hello, World!");

List<ExtratoEntrega> extratos = new List<ExtratoEntrega>();

extratos.Add(new ExtratoEntrega(1,2));
extratos.Add(new ExtratoEntrega(3,4));
extratos.Add(new ExtratoEntrega(5,6));
extratos.Add(new ExtratoEntrega(7,8));

DadoBruto dado = new DadoBruto(extratos);

Console.WriteLine("Lista antes.");
foreach (var item in dado.items)
{
    Console.WriteLine($"{item.idPeriodicidade} - {item.Periodo}");
}

var dados = dado.items.Select(x=> x).Where(x=> x.idPeriodicidade != 3 && x.Periodo != 4).ToList();

foreach (var item in dados)
{
    dado.items.Remove(item);
}


Console.WriteLine("Lista Depois.");
foreach (var item in dado.items)
{
    Console.WriteLine($"{item.idPeriodicidade} - {item.Periodo}");
}