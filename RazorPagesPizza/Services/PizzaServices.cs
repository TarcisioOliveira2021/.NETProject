using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesPizza.Models;

namespace RazorPagesPizza.Services
{
    public static class PizzaServices
    {
        static List<Pizza> Pizzas {get;}
        static int nextId = 3;

        //Cria uma lista de pizzas.
        static PizzaServices(){
            Pizzas = new List<Pizza>{
                    new Pizza{Id = 1, Name="Marguerita", Price=20.00M, Size=PizzaSize.Medium, IsGlutenFree=false},
                    new Pizza{Id = 2, Name="Calabresa", Price=22.00M, Size=PizzaSize.Large, IsGlutenFree=false}
            };
        }

        //Pega todas as pizzas da lista de "Pizzas".
        public static List<Pizza> GetAll() => Pizzas;

        //Busca a pizza pelo Id.
        public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        //Adiciona uma pizza.
        public static void Add(Pizza pizza){
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
            Console.WriteLine(pizza.Name);
            Console.WriteLine(pizza.Size);
            Console.WriteLine(pizza.Price);
        }

        //Deletar uma pizza.
        public static void Delete(int id){

            //Armazena o id da pizza desejada para deletar.
            var pizza = Get(id);

            //Se ele não existir acabe aqui.
            if(pizza is null){
                return;
            }

            //Se existir remove da lista de pizzas.
            Pizzas.Remove(pizza);
        }

        public static void update(Pizza pizza){
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
                if (index == -1)
                    return;
                Pizzas[index] = pizza;
        }
    }
}