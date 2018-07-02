using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace game_review_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        //Get api/games

        //Not sure what I want to do here yet...
        [HttpGet]
        public ActionResult<string> Get()
        {
            //return all games?
            return "Games!";
        }

        //Get api/games
        [HttpGet]
        [Route("{searchValue}")]
        public ActionResult<string> Get(string searchValue)
        {
            //search game db for similar name,
            //return game data
            return searchValue;
        }


    }
}