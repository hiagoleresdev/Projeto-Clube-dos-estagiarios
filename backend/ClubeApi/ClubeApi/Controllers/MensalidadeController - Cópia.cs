using ClubeApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ClubeApi.Infraestruture;
using System.Data.Entity.Infrastructure;

namespace ClubeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensalidadeController : ControllerBase
    {
        private readonly ClubeDbContext _context;

        public MensalidadeController(ClubeDbContext context)
        {
            _context = context;
        }

        //Método get
        [HttpGet("{id}")]
        public async Task<ActionResult<Mensalidade>> GetMensalidade(int id)
        {
            var mensalidade = await _context.Mensalidades.FindAsync(id);

            if (mensalidade == null)
            {
                return NotFound();
            }

            return mensalidade;
        }

        //Método post
        [HttpPost]
        public async Task<ActionResult<Mensalidade>> PostTodoItem(Mensalidade mensalidade)
        {
            _context.Mensalidades.Add(mensalidade);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetMensalidade), new { id = mensalidade.Id }, mensalidade);
        }

        //método put
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMensalidade(int id, Mensalidade mensalidade)
        {
            if (id != mensalidade.Id)
            {
                return BadRequest();
            }

            _context.Entry(mensalidade).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MensalidadeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();


        }

        //Método delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategpria(int id)
        {

            var mensalidade = await _context.Mensalidades.FindAsync(id);
            if (mensalidade == null)
            {
                return NotFound();
            }

            _context.Mensalidades.Remove(mensalidade);
            await _context.SaveChangesAsync();

            return NoContent();


        }

        private bool MensalidadeExists(int id)
        {
            return _context.Mensalidades.Any(e => e.Id == id);
        }


    }
}
