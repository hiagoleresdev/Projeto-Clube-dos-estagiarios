using ClubeApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ClubeApi.Infraestruture;
using System.Data.Entity.Infrastructure;

namespace ClubeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependenteController : ControllerBase
    {
        private readonly ClubeDbContext _context;

        public DependenteController(ClubeDbContext context)
        {
            _context = context;
        }

        //Método get
        [HttpGet("{id}")]
        public async Task<ActionResult<Dependente>> GetDependente(int id)
        {
            var dependente = await _context.Dependentes.FindAsync(id);

            if (dependente == null)
            {
                return NotFound();
            }

            return dependente;
        }

        //Método post
        [HttpPost]
        public async Task<ActionResult<Dependente>> PostTodoItem(Dependente dependente)
        {
            _context.Dependentes.Add(dependente);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetDependente), new { id = dependente.Id }, dependente);
        }

        //método put
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDependente(int id, Dependente dependente)
        {
            if (id != dependente.Id)
            {
                return BadRequest();
            }

            _context.Entry(dependente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DependenteExists(id))
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
        public async Task<IActionResult> DeleteDependente(int id)
        {

            var dependente = await _context.Dependentes.FindAsync(id);
            if (dependente == null)
            {
                return NotFound();
            }

            _context.Dependentes.Remove(dependente);
            await _context.SaveChangesAsync();

            return NoContent();


        }

        private bool DependenteExists(int id)
        {
            return _context.Dependentes.Any(e => e.Id == id);
        }


    }
}
