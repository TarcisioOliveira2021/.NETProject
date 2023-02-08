using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtributos.Validation
{
    public static class AtributoValidator
    {
        public static void Validate(object obj)
        {
            var type = obj.GetType();
            
            foreach (var propriedade in type.GetProperties())
            {
                var atributosRequeridos = propriedade.GetCustomAttributes(typeof(AtributoStringRequerida), false);
                foreach (var atributo in atributosRequeridos)
                {
                    Console.WriteLine("Objeto custom: " + atributo);
                    Console.WriteLine("Propriedade custom identificada: " + propriedade);
                }

                //object valorPropriedade = propriedade.GetValue(obj);
                //if (string.IsNullOrEmpty(valorPropriedade.ToString()))
                //{
                //    //throw new Exception($"A propriedade: {propriedade.Name} não pode ser nula ou vazia.");
                //    Console.WriteLine($"A propriedade: {propriedade.Name} não pode ser nula ou vazia.");
                //}
            }

        }
    }
}
