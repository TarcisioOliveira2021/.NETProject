using Newtonsoft.Json;

namespace ConsumoAPIsinconfi
{
    class Program
    {
        /* MOSTRA O JSON COMPLETO NO TERMINAL.
        HttpClient client = new HttpClient{BaseAddress = new Uri("https://apidatalake.tesouro.gov.br") };
        var response = await client.GetAsync("/ords/siconfi/tt/anexos-relatorios");
        var content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);
        */

        /* MOSTRA OS DADOS DO JSON NO CONSOLE.
        HttpClient client = new HttpClient { BaseAddress = new Uri("https://apidatalake.tesouro.gov.br") };
        var response = await client.GetAsync("/ords/siconfi/tt/anexos-relatorios");
        var content = await response.Content.ReadAsStringAsync();
        var model = JsonConvert.DeserializeObject<Root>(content);
        foreach (var item in model.items)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Esfera: " + item.esfera);
            Console.WriteLine("Demonstrativo: " + item.demonstrativo);
            Console.WriteLine("Anexo: " + item.anexo);
            Console.WriteLine("===================================");
        }
        */


        // Salvando os dados do JSON em um Arquivo de Texto.
        private static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://apidatalake.tesouro.gov.br") };
            var response = await client.GetAsync("/ords/siconfi/tt/anexos-relatorios");
            var content = await response.Content.ReadAsStringAsync();
            Root model = JsonConvert.DeserializeObject<Root>(content);


            //PATH == .NETProject\ConsumoAPIsinconfi\ConsumoAPIsinconfi\bin\Debug\net6.0
            using StreamWriter file = new("anexos-relatioriosSiconfi.txt");
            foreach (var line in model.items)
            {
                await file.WriteLineAsync(line.anexo + " - " + line.demonstrativo + " - " + line.esfera);
            }
        }
    }
}
