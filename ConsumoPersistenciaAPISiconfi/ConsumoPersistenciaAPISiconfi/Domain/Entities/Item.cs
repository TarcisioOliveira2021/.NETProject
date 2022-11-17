using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumoPersistenciaAPISiconfi.Entities
{
    public class Item
    {
        [JsonPropertyName("esfera")]
        public string esfera { get; set; }

        [JsonPropertyName("demonstrativo")]
        public string demonstrativo { get; set; }

        [JsonPropertyName("anexo")]
        public string anexo { get; set; }
    }
}
