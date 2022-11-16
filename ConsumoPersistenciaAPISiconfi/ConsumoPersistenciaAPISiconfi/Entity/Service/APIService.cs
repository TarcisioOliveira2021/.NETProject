using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoPersistenciaAPISiconfi.Entity.Service
{
    internal class APIService
    {
        public async Task<Root> Convertion()
        {
            HttpClient client = new HttpClient
                { BaseAddress = new Uri("https://apidatalake.tesouro.gov.br") };

            var response = await client.GetAsync("/ords/siconfi/tt/anexos-relatorios");
            var content  = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<Root>(content);

            return model;
        }
    }
}
