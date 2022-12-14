using AutoMapperProject.Models.Enum;

namespace AutoMapperProject.Models
{
    public class CarroViewModel
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public Categoria Categoria { get; set; }
    }
}