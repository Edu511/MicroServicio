using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicioPJ.Database;
using ServicioPJ.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicioPJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PjController : ControllerBase
    {
        DatabaseContext db;

        public PjController()
        {
            db = new DatabaseContext();
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<MicroPJ> Get()
        {
            return db.DBPJ.ToList();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public MicroPJ Get(int id)
        {
            return db.DBPJ.Find(id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public IActionResult Post([FromBody] MicroPJ model)
        {
            try 
            {
                db.DBPJ.Add(model);
                db.SaveChanges();
                
                return StatusCode(StatusCodes.Status201Created);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        //// PUT api/<UsuarioController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UsuarioController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
