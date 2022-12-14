using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperProject.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class CarroController : ControllerBase
    {
        private readonly IMapper _mapper;

        public CarroController(IMapper map){
            _mapper = map;
        }

        //Implementação do método post para enviar dados para a aplicação.
        [HttpPost]
        public ActionResult Post(CarroInputModel carroInputModel){
            var carro = _mapper.Map<Carro>(carroInputModel);
            return Ok(carro);
        }


        //GetById 
        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            var carro = new Carro(0,"PKLA0000","Preto","Corsa",209031041);
            var carroViewModel = _mapper.Map<CarroViewModel>(carro); //Mapeia o carro na CarroViewModel.
            return Ok(carroViewModel);
        }
    }
}