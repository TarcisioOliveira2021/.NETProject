using ConsumoPersistenciaAPISiconfi.Entities;
using ConsumoPersistenciaAPISiconfi.Entities.Service;
using System.Reflection;

namespace ConsumoPersistenciaAPISiconfi
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            APIService api = new APIService();
            Root jObj = await api.Convertion();

            foreach (var item in jObj.items)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("Esfera: " + item.esfera);
                Console.WriteLine("Demonstrativo: " + item.demonstrativo);
                Console.WriteLine("Anex: " + item.anexo);
                Console.WriteLine("===================================");
            }
        }
    }
}