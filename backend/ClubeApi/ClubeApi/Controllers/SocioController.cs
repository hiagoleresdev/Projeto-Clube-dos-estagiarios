﻿using ClubeApi.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Data.Entity;

namespace ClubeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {
        
        private readonly DbContext _context;
      
        public SocioController(DbContext context)
        {
            _context = context;
        }

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [SwaggerResponse(409, "Domain Exception", typeof(string))]
        public async Task<ActionResult<int>> PostSocioAsync(Socio socio)
        {
            try
            {
                /*
                var id = _context.PostSocioAsync(socio); 

                return Ok(id);*/
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}