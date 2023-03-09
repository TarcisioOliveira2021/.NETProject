using POCDatatable.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCDatatable.Service.Interface
{
    public interface ISiconfiAPIService
    {
        Task<DadosBrutosAPI> ObterDadosApi();
    }
}
