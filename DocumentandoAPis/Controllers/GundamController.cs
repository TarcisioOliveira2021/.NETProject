using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentandoAPis.Service;
using Microsoft.AspNetCore.Mvc;

namespace DocumentandoAPis.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class GundamController : ControllerBase
    {
        private readonly ILogger<GundamController> _logger;

        public GundamController(ILogger<GundamController> logger){
            _logger = logger;
        }


        [HttpGet("obterTodos")]
        public ActionResult<List<Gundam>> ObterTodos(){
            var gundam = GundamService.ObterTodosGundam();
            return Ok(gundam);
        }

        [HttpGet("obterGundam")]
        public ActionResult<Gundam> ObterGundam(int id){
            var gundam = GundamService.ObterGundam(id);

            if(gundam == null){
                return NotFound();
            }

            return Ok(gundam);
        }

        [HttpPost("criarGundam")]
        public IActionResult CriarGundam(Gundam gundam){
            GundamService.AdicionarGundam(gundam);
            return CreatedAtAction(nameof(CriarGundam), new{id = gundam.Id}, gundam);
        }

        [HttpPut("atualizarGundam")]
        public IActionResult AtualizarGundam(int id, Gundam gundam){
            if(id != gundam.Id){
                return BadRequest();
            }

            var existeGundam = GundamService.ObterGundam(id);
            if(existeGundam == null){
                return NotFound();
            }

            GundamService.UpdateGundam(gundam);
            return NoContent();
        }

        [HttpDelete("removerGundam")]
        public IActionResult removerGundam(int id){
            var gundamParaDeletar = GundamService.ObterGundam(id);
            if(gundamParaDeletar == null){
                return NotFound();
            }

            GundamService.RemoverGundam(id);
            return NoContent();
        }

    }
}