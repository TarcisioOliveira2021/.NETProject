using Newtonsoft.Json;

/* MOSTRA O JSON COMPLETO NO TERMINAL
HttpClient client = new HttpClient{BaseAddress = new Uri("https://apidatalake.tesouro.gov.br") };
var response = await client.GetAsync("/ords/siconfi/tt/anexos-relatorios");
var content = await response.Content.ReadAsStringAsync();
Console.WriteLine(content);
*/

HttpClient client = new HttpClient { BaseAddress = new Uri("https://apidatalake.tesouro.gov.br") };
var response = await client.GetAsync("/ords/siconfi/tt/anexos-relatorios");
var content = await response.Content.ReadAsStringAsync();

var model = JsonConvert.DeserializeObject<Root>(content);
//var jObj = JsonConvert.DeserializeObject<List<Root>>(content);

foreach (var item in model.items)
{
    Console.WriteLine(item);
}

