using ClubeApi.Domain;
using ClubeApi.Infraestruture;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Data.Entity;

namespace ClubeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {
        
        private readonly ClubeDbContext _context;

        //Método get
        [HttpGet("{id}")]
        public async Task<ActionResult<Socio>> GetSocio(long id)
        {
            var todoItem = await _context.Socios.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        //Método post
        [HttpPost]
        public async Task<ActionResult<Socio>> PostTodoItem(Socio socio)
        {
            _context.Socios.Add(socio);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetSocio), new { id = socio.Id }, socio);
        }


    }
}
