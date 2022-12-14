using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperProject.Models
{
    public class Carro
    {
        public Carro(int id, string placa, string cor, string modelo, int chassi)
        {
            Id = id;
            Placa = placa;
            Cor = cor;
            Modelo = modelo;
            Chassi = chassi;
        }

        public int Id { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int Chassi { get; set; }

    }
}