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

    // PUT action

    // DELETE action
}