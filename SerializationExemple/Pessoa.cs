using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerializationExemple
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public string  Nome { get; set; }

        public Pessoa(int idade, string nome)
        {
            Idade = idade;
            Nome = nome;
        }
    }
}