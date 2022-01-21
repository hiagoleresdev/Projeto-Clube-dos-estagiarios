using ClubeApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Data.Entity;
using ClubeApi.Infrastructure;

namespace ClubeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {
        private readonly ClubeDbContext _context;
      
        public SocioController(ClubeDbContext context)
        {
            _context = context;
        }

        //Método para listar sócios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Socio>>> GetSociosAsync()
        {
            try
            {
                return await _context.Socios.ToListAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Método para selecionar sócio por ID
        [HttpGet("{Id}")]
        public async Task<ActionResult<Socio>> GetSocioAsync(int id)
        {
            try
            {
                Socio socio = await _context.Socios.FindAsync(id);

                if(socio == null)
                    return NotFound();

                return socio;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Método para cadastrar sócio
        [HttpPost]
        public async Task<ActionResult<int>> PostSocioAsync(Socio socio)
        {
            try
            {
                await _context.Socios.AddAsync(socio);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
