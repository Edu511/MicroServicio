using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicioUsuario.Database.Entities;
using ServicioUsuario.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServicioUsuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosPJEHController : ControllerBase
    {
        DatabaseContext db;
        public DatosPJEHController()
        {
            db = new DatabaseContext();
        }

        // GET: api/<ExternalApiController>
        [HttpGet]
        public IEnumerable<DatosPJEH> Get()
        {
            return db.DatosPJEH.ToList();
        }

        // GET api/<ExternalApiController>/5
        [HttpGet("{id}")]
        public DatosPJEH Get(int id)
        {
            return db.DatosPJEH.Find(id);
        }

        // POST api/<ExternalApiController>
        [HttpPost]
        public IActionResult Post([FromBody] DatosPJEH model)
        {
            try
            {
                db.DatosPJEH.Add(model);
                db.SaveChanges();

                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/<ExternalApiController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DatosPJEH modelo)
        {
            try
            {
                var entity = db.DatosPJEH.FirstOrDefault(e => e.IDSolicitud == id);
                entity.Estado = modelo.Estado;
                entity.NoOficioSolicitud = modelo.NoOficioSolicitud;
                entity.NUC = modelo.NUC;
                entity.TipoAudiencia = modelo.TipoAudiencia;
                entity.FechaAudiencia = modelo.FechaAudiencia;
                entity.SalaAsignada = modelo.SalaAsignada;
                entity.JuzgadoAsignado = modelo.JuzgadoAsignado;
                entity.AsuntoRelacionado = modelo.AsuntoRelacionado;
                db.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, entity);
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // DELETE api/<ExternalApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var entity = db.DatosPJEH.Remove(db.DatosPJEH.FirstOrDefault(e => e.IDSolicitud == id));
                db.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, entity);

            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
