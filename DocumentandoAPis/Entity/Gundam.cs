using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentandoAPis
{
    public class Gundam
    {
        public int Id {get; set;}
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public string Operator { get; set; }
        public int Height { get; set; }
        public string FuelType { get; set; }
        public string FrameMaterial { get; set; }

    }
}