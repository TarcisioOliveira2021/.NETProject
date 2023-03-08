using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MeuChatGPT.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuChatGPT.Controllers
{
    [ApiController]
    [Route("api/meuchatgpt")]
    public class MeuController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public MeuController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string text, [FromServices] IConfiguration configuration)
        {
            var key = configuration.GetValue<string>("APIKEY");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",key);

            var model = new RequestModel(text);

            var request = JsonSerializer.Serialize(model);
            var content = new StringContent(request, Encoding.UTF8, "application/json");

            var resp = await _httpClient.PostAsync("https://api.openai.com/v1/completions",content);

            var result = await resp.Content.ReadFromJsonAsync<ResponseModel>();
            //Pega do arrai de choices o primeiro item (text).
            var promptResponse = result.choices.First();

            //Parametros que vão ser substituidos por vazio.
            return Ok(promptResponse.text.Replace("\n", "").Replace("\t", ""));
        }
    }
}