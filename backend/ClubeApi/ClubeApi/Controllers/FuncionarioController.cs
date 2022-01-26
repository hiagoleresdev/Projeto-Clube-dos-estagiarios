using ClubeApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ClubeApi.Infraestruture;
using System.Data.Entity.Infrastructure;

namespace ClubeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly ClubeDbContext _context;

        public FuncionarioController(ClubeDbContext context)
        {
            _context = context;
        }

        //Método get
        [HttpGet("{id}")]
        public async Task<ActionResult<Funcionario>> GetFuncionario(int id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return funcionario;
        }

        //Método post
        [HttpPost]
        public async Task<ActionResult<Funcionario>> PostTodoItem(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetFuncionario), new { id = funcionario.Id }, funcionario);
        }

        //método put
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuncionarios(int id, Funcionario funcionario)
        {
            if (id != funcionario.Id)
            {
                return BadRequest();
            }

            _context.Entry(funcionario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FuncionarioExists(id))
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
        public async Task<IActionResult> DeleteFuncionario(int id)
        {

            var funcionario = await _context.Funcionarios.FindAsync(id);
            if (funcionario == null)
            {
                return NotFound();
            }

            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();

            return NoContent();


        }


        //Validar login e senha
        [HttpGet()]
        public async Task<ActionResult<int>> GetSenha(Funcionario funcionario)
        {

            try
            {
                var funcionarioID = await _context.Funcionarios.FindAsync(funcionario.Id);
                if (funcionarioID.Usuario.Equals(funcionario.Usuario) && funcionarioID.Senha.Equals(funcionario.Usuario))
                {

                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }

        }


        private bool FuncionarioExists(int id)
        {
            return _context.Funcionarios.Any(e => e.Id == id);
        }


    }
}
