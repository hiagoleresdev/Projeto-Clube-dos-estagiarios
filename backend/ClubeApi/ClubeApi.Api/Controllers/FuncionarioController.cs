﻿using ClubeApi.Application.DTOs;
using ClubeApi.Application.Interfaces.ApplicationServices;
using Microsoft.AspNetCore.Mvc;

namespace ClubeApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : Controller
    {
        //Atributo para injeção de dependência do serviço da aplicação
        private readonly IApplicationServiceFuncionario applicationServiceFuncionario;

        //Construtor
        public FuncionarioController(IApplicationServiceFuncionario applicationServiceFuncionario)
        {
            this.applicationServiceFuncionario = applicationServiceFuncionario;
        }

        // GET: Selecionar funcionário por ID
        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            try
            {
                return Ok(applicationServiceFuncionario.GetById(id));
            }
            catch
            {
                return NotFound();
            }
        }

        // POST: Cadastrar funcionário
        [HttpPost]
        public ActionResult Add([FromBody] FuncionarioDTO FuncionarioDTO)
        {
            try
            {
                if (FuncionarioDTO == null)
                    return NotFound();

                applicationServiceFuncionario.Add(FuncionarioDTO);
                return Ok("Funcionário cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: Atualizar funcionário
        [HttpPut]
        public ActionResult Update([FromBody] FuncionarioDTO funcionarioDTO)
        {
            try
            {
                if (funcionarioDTO == null)
                    return NotFound();

                applicationServiceFuncionario.Update(funcionarioDTO);
                return Ok("Funcionario atualizado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: Deletar funcionário
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                applicationServiceFuncionario.Delete(id);
                return Ok("Funcionário deletado com sucesso");
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: Validar login
        [HttpGet]
        public ActionResult<int> Validate(string usuario, string senha)
        {
            try
            {
                return applicationServiceFuncionario.Validate(usuario, senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}