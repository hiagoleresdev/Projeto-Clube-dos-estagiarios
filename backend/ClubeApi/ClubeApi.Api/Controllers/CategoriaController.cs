using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using Microsoft.AspNetCore.Mvc;

namespace ClubeApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : Controller
    {
        //Atributo para injeção de dependência do serviço da aplicação
        private readonly IApplicationServiceCategoria applicationServiceCategoria;

        //Construtor
        public CategoriaController(IApplicationServiceCategoria applicationServiceCategoria)
        {
            this.applicationServiceCategoria = applicationServiceCategoria;
        }

        // GET: Selecionar categoria por ID
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            try
            {
                return Ok(applicationServiceCategoria.GetById(id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // POST: Cadastrar categoria
        [HttpPost]
        public ActionResult Add([FromBody] CategoriaDTO categoriaDTO)
        {
            try
            {
                if (categoriaDTO == null)
                    return NotFound();

                applicationServiceCategoria.Add(categoriaDTO);
                return Ok("Categoria cadastrada com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: Atualizar categoria
        [HttpPut]
        public ActionResult Update([FromBody] CategoriaDTO categoriaDTO)
        {
            try
            {
                if (categoriaDTO == null)
                    return NotFound();

                applicationServiceCategoria.Update(categoriaDTO);
                return Ok("Categoria atualizada com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE: Deletar categoria
        [HttpDelete]
        public ActionResult Delete([FromBody] CategoriaDTO categoriaDTO)
        {
            try
            {
                if (categoriaDTO == null)
                    return NotFound();

                applicationServiceCategoria.Update(categoriaDTO);
                return Ok("Categoria deletada com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
