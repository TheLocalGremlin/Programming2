using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace APIserver.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {

        static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Cubone", Type = "Ground"},
            new Pokemon() {Name = "Dragapult", Type = "Dragon/Ghost"}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[1]);
        }
    }
}
