using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nutricion.API.Data;
using Nutricion.API.Models;

namespace Nutricion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMCController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public IMCController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost("registar")]
        public async Task<ActionResult<int>> Guardar(IMC imc)
        {
            var nuevoIMC = imc;
            context.Add(nuevoIMC);
            //context.RegistrosIMC.Add(nuevoIMC);
            await context.SaveChangesAsync();
            if(nuevoIMC.Id > 0) 
            {
                return nuevoIMC.Id;
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("lista")]
        public async Task<ActionResult<List<IMC>>> Registros()
        {
            var lista = new List<IMC>();
            lista = await context.RegistrosIMC.ToListAsync();
            if (lista.Count > 0) 
            {
                return lista;
            }
            else
            {
                return NoContent();
            }      
        }

        [HttpGet("solo/{id}")]
        public async Task<ActionResult<IMC>> SoloRegistro(int id)
        {
            var solo = new IMC();
            
            solo = await context.RegistrosIMC.Where(i => i.Id == id)
                .FirstOrDefaultAsync();
            
            if (solo != null)
            {
                return solo;
            }
            else
            {
                return NoContent();
            }
        }
    }
}
