using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCorePetaPoco.Models;
using AspNetCorePetaPoco.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCorePetaPoco.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioRepository repository;

        public FuncionarioController(IConfiguration configuration){
            repository = new FuncionarioRepository(configuration);
        }


        //Get todos os funcionarios
        public ActionResult Index(){
            return View(repository.FindAll().ToList());
        }

        //Find by id
        public ActionResult Details (int? id){
            if ( id == null){
                return StatusCode(StatusCodes.Status404NotFound);
            }
            Funcionario funcionario = repository.FindById(id.Value);
            if(funcionario == null){
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(funcionario);
        }


        //Criando um funcionario/create
        public ActionResult Create(){
            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id, Name, Idade")] Funcionario funcionario){
            if(ModelState.IsValid){
                repository.Add(funcionario);
                return RedirectToAction("Index");
            }

            return View(funcionario);
        }


        public ActionResult Edit(int? id){
            if(id == null){
                return StatusCode(StatusCodes.Status404NotFound);
            }
            Funcionario funcionario = repository.FindById(id.Value);
            if(funcionario == null){
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(funcionario);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id, Name, Idade")] Funcionario funcionario){
            if(ModelState.IsValid){
                repository.Add(funcionario);
                return RedirectToAction("Index");
            }

            return View(funcionario);
        }


        public ActionResult Delete(int? id){
            if(id == null){
                return StatusCode(StatusCodes.Status404NotFound);
            }
            Funcionario funcionario = repository.FindById(id.Value);
            if(funcionario == null){
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return View(funcionario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id){
            repository.Remove(id);
            return RedirectToAction("Index");
        }
    }
}