using ClubeApi.Common;
using ClubeApi.Domain;
using ClubeApi.Infraestruture.Repository;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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
                var id = await _socioService.PostSocioAsync(socio); //tirei o await pq tava dano erro (u.u)

                return Ok(id);
            }
            catch (DomainException erro)
            {
                return Conflict(erro.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Socio))]
        public async Task<ActionResult<Socio>> GetSocio()
        {
            return Ok(new Socio { Id = 1, Nome = "Hiago", NumeroCartao = 12341234, Email = "hiagoleres2@gmail.com", Parentesco="" });
        }
    }
}
