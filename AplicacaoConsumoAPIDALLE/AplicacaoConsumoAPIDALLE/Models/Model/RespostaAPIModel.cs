using AplicacaoConsumoAPIDALLE.Models.Model;

namespace AplicacaoConsumoAPIDALLE.Models
{
    public class RespostaAPIModel
    {
        public long created { get; set; }
        public List<Link>? data { get; set;}
    }
}

