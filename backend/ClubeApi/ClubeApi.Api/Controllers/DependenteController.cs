using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using Microsoft.AspNetCore.Mvc;

namespace ClubeApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DependenteController : Controller
    {
        //Atributo para injeção de dependência do serviço da aplicação
        private readonly IApplicationServiceDependente applicationServiceDependente;

        //Construtor
        public DependenteController(IApplicationServiceDependente applicationServiceDependente)
        {
            this.applicationServiceDependente = applicationServiceDependente;
        }

        // GET: Listar dependentes
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            try
            {
                return Ok(applicationServiceDependente.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Selecionar dependente por ID
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            try
            {
                return Ok(applicationServiceDependente.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST: Cadastrar dependente
        [HttpPost]
        public ActionResult Add([FromBody] DependenteDTO dependenteDTO)
        {
            try
            {
                if (dependenteDTO == null)
                    return NotFound();

                applicationServiceDependente.Add(dependenteDTO);
                return Ok("Dependente cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: Atualizar dependente
        [HttpPut]
        public ActionResult Update([FromBody] DependenteDTO dependenteDTO)
        {
            try
            {
                if (dependenteDTO == null)
                    return NotFound();

                applicationServiceDependente.Update(dependenteDTO);
                return Ok("Dependente atualizado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: Deletar dependente
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                applicationServiceDependente.Delete(id);
                return Ok("Dependente deletado com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
