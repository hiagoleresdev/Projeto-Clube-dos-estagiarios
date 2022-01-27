using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using Microsoft.AspNetCore.Mvc;

namespace ClubeApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MensalidadeController : Controller
    {
        //Atributo para injeção de dependência do serviço da aplicação
        private readonly IApplicationServiceMensalidade applicationServiceMensalidade;

        //Construtor
        public MensalidadeController(IApplicationServiceMensalidade applicationServiceMensalidade)
        {
            this.applicationServiceMensalidade = applicationServiceMensalidade;
        }

        // GET: Listar mensalidades
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                return Ok(applicationServiceMensalidade.GetAll());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // GET: Selecionar mensalidade por ID
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            try
            {
                return Ok(applicationServiceMensalidade.GetById(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // POST: Cadastrar mensalidade
        [HttpPost]
        public ActionResult Add([FromBody] MensalidadeDTO mensalidadeDTO)
        {
            try
            {
                if (mensalidadeDTO == null)
                    return NotFound();

                applicationServiceMensalidade.Add(mensalidadeDTO);
                return Ok("Mensalidade cadastrada com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: Atualizar mensalidade
        [HttpPut]
        public ActionResult Update([FromBody] MensalidadeDTO mensalidadeDTO)
        {
            try
            {
                if (mensalidadeDTO == null)
                    return NotFound();

                applicationServiceMensalidade.Update(mensalidadeDTO);
                return Ok("Mensalidade atualizada com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE: Deletar mensalidade
        [HttpDelete]
        public ActionResult Delete([FromBody] MensalidadeDTO mensalidadeDTO)
        {
            try
            {
                if (mensalidadeDTO == null)
                    return NotFound();

                applicationServiceMensalidade.Update(mensalidadeDTO);
                return Ok("Mensalidade deletada com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
