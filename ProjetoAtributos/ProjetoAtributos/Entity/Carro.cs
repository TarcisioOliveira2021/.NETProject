using ProjetoAtributos.Enum;
using ProjetoAtributos.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtributos.Entity
{
    public class Carro
    {
        public Carro(int ano, string nome, string chassi, TipoMotor tipoMotor)
        {
            Ano = ano;
            Nome = nome;
            Chassi = chassi;
            TipoMotor = tipoMotor;
        }

        public int Ano { get; set; }

        [AtributoStringRequerida(nameof(Nome))]
        public string Nome { get; set; }
        public string Chassi { get; set; }
        public TipoMotor TipoMotor { get; set; }
    }
}
