﻿using ClubeApi.Domain;
using ClubeApi.Infraestruture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using System.Data.Entity;


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

        //Método get
        [HttpGet("{id}")]
        public async Task<ActionResult<Socio>> GetSocio(int id)
        {
            var todoItem = await _context.Socios.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        //Método get all
        /*
        [HttpGet]
        public  async Task<IActionResult> Get()
        {
            try
            {
                var result = await _context.GetAllSocio(true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex);
            }
        }*/

        //Método post
        [HttpPost]
        public async Task<ActionResult<Socio>> PostTodoItem(Socio socio)
        {
            _context.Socios.Add(socio);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetSocio), new { id = socio.Id }, socio);
        }

        //Método put

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSocio(int id, Socio socio)
        {
            if (id != socio.Id)
            {
                return BadRequest();
            }

            _context.Entry(socio).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SocioExists(id))
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
        public async Task<IActionResult> DeleteSocio(int id)
        {

            var socio = await _context.Socios.FindAsync(id);
            if (socio == null)
            {
                return NotFound();
            }

            _context.Socios.Remove(socio);
            await _context.SaveChangesAsync();

            return NoContent();

     
        }

        private bool SocioExists(int id)
        {
            return _context.Socios.Any(e => e.Id == id);
        }



    }
}
