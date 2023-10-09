using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using SerializationExemple;

Pessoa pessoa = new Pessoa(22,"Jefferson");
var jsonDe_pessoa = JsonConvert.SerializeObject(pessoa, Formatting.Indented);
Console.WriteLine(jsonDe_pessoa);
