using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
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
    public class ExternalApiController : ControllerBase
    {

        DatabaseContext db;

        public ExternalApiController()
        {
            db = new DatabaseContext();
        }
        // GET: api/<ExternalApiController>
        [HttpGet]
        public void GetDatosExternos()
        {
            /*string api_url = String.Format("http://localhost:29064/api/datospjeh/1");
            WebRequest request = WebRequest.Create(api_url);
            request.Method = "GET";
            HttpWebResponse response = null;
            response = (HttpWebResponse)request.GetResponse();

            string stream_result = null;
            using (Stream stream = response.GetResponseStream())
            {
                
                StreamReader response_stream = new StreamReader(stream);
                stream_result = response_stream.ReadToEnd();
                response_stream.Close();

                Console.WriteLine(response_stream);

                return StatusCode(StatusCodes.Status201Created, stream_result);

            }*/

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:29064/api/");
                //HTTP GET
                var responseTask = client.GetAsync("datospjeh");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var students = readTask.Result;

                    foreach (var student in students)
                    {
                        Console.WriteLine(student);
                    }


                    return;
                }
            }
            Console.ReadLine();


        }

        
    }
}
