using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
    {
        private static List<Character> Characters = new List<Character>() {
            new Character(),
            new Character{Id=1,Name="Sam"},
            new Character{Id=2,Name="Ahmed"}
        };
        
        [HttpGet("getAll")]
        public ActionResult<List<Character>> Get(){

            return Ok(Characters);
        }

        [HttpGet("getSingle")]

        public ActionResult<Character> GetSingle(int Id){
            return Ok(Characters.FirstOrDefault(c => c.Id == Id));
        }
    }
}