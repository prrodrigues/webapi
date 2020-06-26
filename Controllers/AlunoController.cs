using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectShcool_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(new List<String> { "a", "b", "c" }.ToArray());
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpGet("{filt}")]
        public IActionResult Get(string filt)
        {
            try
            {
                return Ok((new List<String> { "a", "b", "c" }).Where(x => x == filt));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }

        [HttpPost]
        public IActionResult Post(string filt)
        {
            try
            {
                return Ok((new List<String> { "a", "b", "c" }).Where(x => x == "filt"));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }




        [HttpPut("{professorId}")]
        public IActionResult Put(int professorId)
        {
            try
            {
                return Ok((new List<String> { "a", "b", "c" }).Where(x => x == "as"));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }



        [HttpDelete("{professorId}")]
        public IActionResult HttpDelete(int professorId)
        {
            try
            {
                return Ok((new List<String> { "a", "b", "c" }).Where(x => x == ""));
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }
        }


    }



}


}
