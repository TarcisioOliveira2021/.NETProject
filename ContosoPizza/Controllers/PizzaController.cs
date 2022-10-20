using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> listAll() => PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> FindById(int id)
    {
        var Pizza = PizzaService.Get(id);

        if(Pizza == null)
        {
            return NotFound();
        }

        return Pizza;
    }


    // POST action
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Create), new {id = pizza.Id}, pizza);
    }

    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        //Caso o ID seja diferente to tipo id temos um err 400.
        if(id != pizza.Id){
            return BadRequest();
        }

        // Caso a pizza não seja encontrada.
        var isExistPizza = PizzaService.Get(id);
        if(isExistPizza is null){
            return NotFound();
        }

        //Dando update na pizza
        PizzaService.Update(pizza);
        return NoContent();
    }

    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        //Armazena a pizza para deletar.
        var pizzErase = PizzaService.Get(id);

        //Verifica se a pizza existe.
        if(pizzErase is null){
            return NotFound();
        }

        //Deleta a pizza.
        PizzaService.Delete(id);
        return NoContent();
    }

}