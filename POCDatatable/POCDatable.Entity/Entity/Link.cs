using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace POCDatatable.Entity.Entity
{
    public class Link
    {
        [JsonPropertyName("rel")]
        public string rel { get; set; }

        [JsonPropertyName("href")]
        public string href { get; set; }
    }
}
