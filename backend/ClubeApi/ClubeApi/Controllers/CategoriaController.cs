using ClubeApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ClubeApi.Infrastructure;

namespace ClubeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ClubeDbContext _context;
      
        public CategoriaController(ClubeDbContext categoria)
        {
            _context = categoria;
        }

    
        /*
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [SwaggerResponse(409, "Domain Exception", typeof(string))]
        public async Task<ActionResult<int>> PostCategoriaAsync(Categoria categoria)
        {
            try
            {
                var id = _context.PostCategoriaAsync(categoria); 

                return Ok(id);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        */
    }
}
