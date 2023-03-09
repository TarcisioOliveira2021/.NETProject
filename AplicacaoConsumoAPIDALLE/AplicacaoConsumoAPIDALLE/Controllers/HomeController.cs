using AplicacaoConsumoAPIDALLE.Models;
using AplicacaoConsumoAPIDALLE.Models.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;

namespace AplicacaoConsumoAPIDALLE.Controllers
{
    public class HomeController : Controller
    {
        private string APIKEY = string.Empty;

        public HomeController(IConfiguration c)
        {
            APIKEY = c.GetSection("OPENAI-API-KEY").Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GerandoImagem([FromBody] DadosEntrada dadosEntrada)
        {
            var resp = new RespostaAPIModel();
            using (var cliente = new HttpClient())
            {
                cliente.DefaultRequestHeaders.Clear();
                cliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKEY);
                var mensagem = await cliente.PostAsync("https://api.openai.com/v1/images/generations",
                    new StringContent(JsonConvert.SerializeObject(dadosEntrada),
                    Encoding.UTF8, "application/json"));

                if (mensagem.IsSuccessStatusCode)
                {
                    var conteudo = await mensagem.Content.ReadAsStringAsync();
                    resp = JsonConvert.DeserializeObject<RespostaAPIModel>(conteudo);
                }
            }

            return Json(resp);
        }

    }
}