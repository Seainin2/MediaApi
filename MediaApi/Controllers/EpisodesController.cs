using MediaApi.Data;
using MediaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MediaApi.Controllers
{
    [ApiController]
    public class EpisodesController : ControllerBase
    {

        private IEpisodeData _Data;

        public EpisodesController(IEpisodeData allData)
        {
            _Data = allData;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetEpisodes()
        {
            return Ok(_Data.GetEpisodes());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetEpisode(Guid id)
        {
            var media = _Data.GetEpisode(id);
            if (media != null)
            {
                return Ok(media);
            }

            return NotFound($"Episode with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddEpisode(Episode episode)
        {
          
            return Ok(_Data.AddEpisode(episode));

        }

        [HttpGet]
        [Route("api/[controller]/Season/{id}")]

        public IActionResult GetGamesByCreatingPropertyId(Guid id)
        {
            var episode = _Data.GetEpisodesBySeasonId(id);
            if (episode != null)
            {
                return Ok(episode);
            }

            return NotFound($"Episode with Id: {id} was not found");
        }

    }
}
