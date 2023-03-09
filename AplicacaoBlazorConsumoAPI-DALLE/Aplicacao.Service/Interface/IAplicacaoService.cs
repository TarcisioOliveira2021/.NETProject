using Aplicacao.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Service.Interface
{
    public interface IAplicacaoService
    {
        Task<RespostaAPI> ConsumoAPI(DadosEntrada dadosEntrada);
    }
}
