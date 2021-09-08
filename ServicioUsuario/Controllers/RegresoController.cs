using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServicioUsuario.Database.Entities;
using ServicioUsuario.Database;
using Newtonsoft.Json;

namespace ServicioUsuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegresoController : ControllerBase
    {
        public async Task<IActionResult> Index()
        {
            /*List<DatosPJEH> datos_lista = new List<DatosPJEH>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:29064/api/datospjeh"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    datos_lista = JsonConvert.DeserializeObject<List<DatosPJEH>>(apiResponse);
                }
            }*/

            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
