using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ProjectShcool_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<String> {"a", "b" , "c"}.ToArray());
        }

        [HttpGet("{filt}")]
        public IActionResult Get(string filt)
        {
            return Ok((new List<String> {"a", "b" , "c"}).Where(x => x == filt));
        }


    }

}
