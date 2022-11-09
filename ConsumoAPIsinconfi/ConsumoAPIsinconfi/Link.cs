using System.Text.Json.Serialization;
public class Link
{
    [JsonPropertyName("rel")]
    public string rel { get; set; }

    [JsonPropertyName("href")]
    public string href { get; set; }
}

