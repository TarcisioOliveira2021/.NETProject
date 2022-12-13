using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperProject.Models.Enum;

namespace AutoMapperProject.Models
{
    public class CarroInputModel
    {
        public CarroInputModel(Categoria categoria, string placa, string cor)
        {
            Categoria = categoria;
            Placa = placa;
            Cor = cor;
        }

        public Categoria Categoria { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
    }
}