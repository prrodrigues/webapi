using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectShcool_Api.Data;
using ProjectShcool_Api.Models;

namespace ProjectShcool_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        public IRepository _repo { get; }
        public AlunoController(IRepository repo)
        {
            this._repo = repo;
        }

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
        public async Task<IActionResult> Post(Aluno model)
        {
            try
            {
                _repo.Add(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Created($"/api/aluno/{model.id}", model);
                }
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");
            }

            return BadRequest();

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



