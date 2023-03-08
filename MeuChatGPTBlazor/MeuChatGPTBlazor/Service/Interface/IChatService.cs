using Microsoft.AspNetCore.Mvc;

namespace MeuChatGPTBlazor.Service.Interface
{
    public interface IChatService
    {
        Task<string> Get(string texto);
    }
}
