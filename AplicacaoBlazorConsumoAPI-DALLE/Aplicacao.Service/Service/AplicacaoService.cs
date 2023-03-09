using Aplicacao.Entity.Entity;
using Aplicacao.Service.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Service.Service
{
    public class AplicacaoService : IAplicacaoService
    {
        private string APIKEY = string.Empty;

        public AplicacaoService(IConfiguration configuration) {
#pragma warning disable CS8601 // Possível atribuição de referência nula.
            APIKEY = configuration.GetSection("OPENAI-API-KEY").Value;
#pragma warning restore CS8601 // Possível atribuição de referência nula.
        }

        public async Task<RespostaAPI> ConsumoAPI(DadosEntrada dadosEntrada)
        {
            var resposta = new RespostaAPI();
            var cliente = new HttpClient();
            cliente.DefaultRequestHeaders.Clear();
            cliente.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", APIKEY);

            var mensagem = await cliente.PostAsync("https://api.openai.com/v1/images/generations",
                new StringContent(JsonConvert.SerializeObject(dadosEntrada), Encoding.UTF8, "application/json"));

            if (mensagem.IsSuccessStatusCode)
            {
                var conteudo = await mensagem.Content.ReadAsStringAsync();
                resposta = JsonConvert.DeserializeObject<RespostaAPI>(conteudo);
            }

            if (resposta != null)
            {
                return (resposta);
            }

            else
            {
                throw new ArgumentNullException();
            }

        }
    }
}
