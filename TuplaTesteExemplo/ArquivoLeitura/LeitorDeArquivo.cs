using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuplaTesteExemplo.ArquivoLeitura
{
    public class LeitorDeArquivo
    {
        private string FilePath;

        public LeitorDeArquivo(string path)
        {
            FilePath = path;
        }

        public (bool Sucesso, string[] Linhas, int QtdLinhas, Exception? ex) LerArquivo()
        {
            try{
              string[] linhasArquivo = File.ReadAllLines(this.FilePath);
              return(true,linhasArquivo,linhasArquivo.Count(),null);

            }catch (Exception ex){
                return (false, new string[0],0,ex);
            }
        }
    }
}