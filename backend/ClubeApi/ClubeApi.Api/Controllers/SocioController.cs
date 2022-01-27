using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using Microsoft.AspNetCore.Mvc;

namespace ClubeApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocioController : Controller
    {
        //Atributo para injeção de dependência do serviço da aplicação
        private readonly IApplicationServiceSocio applicationServiceSocio;

        //Construtor
        public SocioController(IApplicationServiceSocio applicationServiceSocio)
        {
            this.applicationServiceSocio = applicationServiceSocio;
        }

        // GET: Listar sócios
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                return Ok(applicationServiceSocio.GetAll());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // GET: Selecionar sócio por ID
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            try
            {
                return Ok(applicationServiceSocio.GetById(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // POST: Cadastrar sócio
        [HttpPost]
        public ActionResult Add([FromBody] SocioDTO socioDTO)
        {
            try
            {
                if (socioDTO == null)
                    return NotFound();

                applicationServiceSocio.Add(socioDTO);
                return Ok("Sócio cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: Atualizar sócio
        [HttpPut]
        public ActionResult Update([FromBody] SocioDTO socioDTO)
        {
            try
            {
                if (socioDTO == null)
                    return NotFound();

                applicationServiceSocio.Update(socioDTO);
                return Ok("Sócio atualizado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE: Deletar sócio
        [HttpDelete]
        public ActionResult Delete([FromBody] SocioDTO socioDTO)
        {
            try
            {
                if (socioDTO == null)
                    return NotFound();

                applicationServiceSocio.Update(socioDTO);
                return Ok("Sócio deletado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
