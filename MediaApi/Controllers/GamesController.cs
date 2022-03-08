using MediaApi.Data;
using MediaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MediaApi.Controllers
{
    [ApiController]
    public class GamesController : ControllerBase
    {

        private IGameData _Data;

        public GamesController(IGameData allData)
        {
            _Data = allData;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetGames()
        {
            return Ok(_Data.GetGames());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetGame(Guid id)
        {
            var media = _Data.GetGame(id);
            if (media != null)
            {
                return Ok(media);
            }

            return NotFound($"Game with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddGame(Game game)
        {

            return Ok(_Data.AddGame(game));

        }

        [HttpGet]
        [Route("api/[controller]/CreatingProperty/{id}")]

        public IActionResult GetGamesByCreatingPropertyId(Guid id)
        {
            var game = _Data.getGamesByCreatingPropertyId(id);
            if (game != null)
            {
                return Ok(game);
            }

            return NotFound($"Game with Id: {id} was not found");
        }

        [HttpGet]
        [Route("api/[controller]/Series/{id}")]

        public IActionResult GetGamesBySeriesId(Guid id)
        {
            var media = _Data.GetGamesBySeriesId(id);
            if (media != null)
            {
                return Ok(media);
            }

            return NotFound($"Movie with Id: {id} was not found");
        }

    }
}
