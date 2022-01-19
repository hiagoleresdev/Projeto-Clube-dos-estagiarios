using ClubeApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ClubeApi.Infraestruture;

namespace ClubeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ClubeDbContext _context;

        public CategoriaController(ClubeDbContext context)
        {
            _context = context;
        }

        //Método get
        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> GetCategoria(int id)
        {
            var todoItem = await _context.Categorias.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        //Método post
        [HttpPost]
        public async Task<ActionResult<Categoria>> PostTodoItem(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetCategoria), new { id = categoria.Id }, categoria);
        }

    }
}
