using CsvHelper;
using CsvHelper.Configuration;
using POC_CsvReader.FormaAlternativa;
using System.Globalization;

namespace POC_Steam_StreamWritter{
    class Program {
        private const string pathCsv = @"C:\PATH\FILENAME.csv";
        private const string pathText = @"C:\PATH\FILENAME.txt";


        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Start();
        }

        //static void Main(string[] args)
        //{
        //    //Cria configurações no Culture.
        //    var confCulture = new CsvConfiguration(CultureInfo.CurrentCulture)
        //    {
        //        Delimiter = ","
        //    };

        //    int cont = 1;

        //    var leitorStream = new StreamReader(pathText);
        //    var arquivoCsv = new CsvReader(leitorStream, confCulture);
            
        //    while (arquivoCsv.Read())
        //    {
        //        Console.WriteLine($"=========={cont}==========");
        //        Console.WriteLine(arquivoCsv.Parser.RawRecord);
        //        Console.WriteLine($"====================");
        //        cont++;
        //    }
            
        //}

        
    }
}

