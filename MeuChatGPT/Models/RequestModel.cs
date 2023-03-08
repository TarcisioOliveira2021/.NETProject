using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuChatGPT.Models
{
    public class RequestModel
    {
        public RequestModel(string prompt)
        {
            this.prompt = prompt;
            this.temperature = 0.2m;
            this.max_tokens = 100;
            this.model = "text-davinci-003";
        }

        public string model { get; set; }
        public string prompt { get; set; }
        public int max_tokens { get; set; }
        public decimal temperature { get; set; }
    }
}