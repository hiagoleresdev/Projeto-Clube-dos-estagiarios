using ClubeApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ClubeApi.Interfaces;

namespace ClubeApi.Controllers
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {
        private readonly ISocioService _socioService;
      
        public SocioController(ISocioService socioService)
        {
            _socioService = socioService;
        }

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [SwaggerResponse(409, "Domain Exception", typeof(string))]
        public async Task<ActionResult<int>> PostSocioAsync(Socio socio)
        {
            try
            {
                var id = _socioService.PostSocioAsync(socio); //tirei o await pq tava dano erro (u.u)

                return Ok(id);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
