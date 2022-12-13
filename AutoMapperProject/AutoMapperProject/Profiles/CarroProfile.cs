using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperProject.Models;

namespace AutoMapperProject.Profiles
{
    public class CarroProfile : Profile
    {
        public CarroProfile(){
            CreateMap<CarroInputModel, Carro>();
            CreateMap<Carro, CarroViewModel>();
        }
    }
}