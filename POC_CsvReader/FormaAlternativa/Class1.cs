using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace POC_CsvReader.FormaAlternativa
{
    class Class1
    {
        private const string pathCsv = @"C:\PATH\FILENAME.csv";
        

        public void Start()
        {
            List<Estados> estadoList = new();

            var confCulture = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ","
            };

            
            var leitorStream = new StreamReader(pathCsv);
            using (var arquivoCsv = new CsvReader(leitorStream, confCulture))
            {
                arquivoCsv.Read();
                arquivoCsv.ReadHeader();
                estadoList = arquivoCsv.GetRecords<Estados>().ToList();
            }

            foreach (var estado in estadoList)
            {
                Console.WriteLine("Nome="+estado.NOME+ "\nCOD=" + estado.COD+ "\nSIGLA=" + estado.SIGLA);
                Console.WriteLine("\n========================");
            }



            


            
        }
    }
}