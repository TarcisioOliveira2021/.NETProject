using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtributos.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AtributoStringRequerida : Attribute
    {
        public string Propriedade { get; set; }

        public AtributoStringRequerida(string _propriedade)
        {
            Propriedade = _propriedade;
        }

        public void Validar(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo propriedadeReflexiva = type.GetProperty(Propriedade);
    
            object valorPropriedade = propriedadeReflexiva.GetValue(obj);

            if (string.IsNullOrEmpty(valorPropriedade.ToString()))
            {
                throw new Exception($"A propriedade: {propriedadeReflexiva.Name} não pode ser nula ou vazia.");
            }

            Console.WriteLine(valorPropriedade.ToString());

        }
    }
}
