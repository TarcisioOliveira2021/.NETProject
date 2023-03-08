using MeuChatGPTBlazor.Model;
using MeuChatGPTBlazor.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace MeuChatGPTBlazor.Service
{
    public class ChatService : IChatService
    {
        private readonly IConfiguration configuration;
        private readonly HttpClient httpClient = new();

        public ChatService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<string> Get(string texto)
        {
            var apiKey = configuration.GetValue<string>("APIKEY");
            httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

            var model = new RequestInputModel(texto);
            var request = JsonSerializer.Serialize(model);
            var content = new StringContent(request, Encoding.UTF8, "application/json");
            var resp = await httpClient.PostAsync("https://api.openai.com/v1/completions", content);
            var result = await resp.Content.ReadFromJsonAsync<ResponseViewModel>();
            var promptResponse = result.choices.First();

            return promptResponse.text.Replace("\n", "").Replace("\t", "");
        }
    }
}
