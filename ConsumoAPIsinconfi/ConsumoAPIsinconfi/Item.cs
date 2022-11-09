using System.Text.Json.Serialization;
public class Item
{
    [JsonPropertyName("esfera")]
    public string esfera { get; set; }

    [JsonPropertyName("demonstrativo")]
    public string demonstrativo { get; set; }

    [JsonPropertyName("anexo")]
    public string anexo { get; set; }
}

