using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumoPersistenciaAPISiconfi.Entities
{
    public class Root
    {
        //prop de navegação
        [JsonPropertyName("items")]
        public List<Item> items { get; set; }

        [JsonPropertyName("hasMore")]
        public bool hasMore { get; set; }

        [JsonPropertyName("limit")]
        public int limit { get; set; }

        [JsonPropertyName("offset")]
        public int offset { get; set; }

        [JsonPropertyName("count")]
        public int count { get; set; }

        //prop de navegação
        [JsonPropertyName("links")]
        public List<Link> links { get; set; }

        //Prop para banco
        public int id { get; set; }
    }
}
