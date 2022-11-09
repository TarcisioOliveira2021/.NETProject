using ConsumoDeApiTeste.Entitites;
using Newtonsoft.Json;

namespace ConsumoDeApiTeste { 
    class Program
    {
        static void Main(string[] args)
        {
            Listar();
        }

         public static void Listar()
            {
             string urlApi = "https://jsonplaceholder.typicode.com/users";
            try
            {
                using(var client = new HttpClient())
                {
                    var response = client.GetStringAsync(urlApi);
                    response.Wait();

                    var resp = JsonConvert.DeserializeObject<User[]>(response.Result).ToList();

                    foreach(var user in resp)
                    {
                        Console.WriteLine("=====================");
                        Console.WriteLine(user.id);
                        Console.WriteLine(user.name);
                        Console.WriteLine(user.username);
                        Console.WriteLine(user.email);
                        Console.WriteLine(user.address);
                        Console.WriteLine("=====================");
                        Console.WriteLine();
                    }
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            }
       

    }
}

