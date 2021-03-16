using System;
using Microsoft.AspNetCore.Mvc;

namespace APIserver.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Hi");
        }
    }
}
