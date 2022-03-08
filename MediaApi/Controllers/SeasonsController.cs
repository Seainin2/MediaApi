using MediaApi.Data;
using MediaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MediaApi.Controllers
{
    [ApiController]
    public class SeasonsController : ControllerBase
    {

        private ISeasonData _Data;

        public SeasonsController(ISeasonData allData)
        {
            _Data = allData;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetSeasons()
        {
            return Ok(_Data.GetSeasons());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetSeason(Guid id)
        {
            var media = _Data.GetSeason(id);
            if (media != null)
            {
                return Ok(media);
            }

            return NotFound($"Season with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddSeason(Season season)
        {

            return Ok(_Data.AddSeason(season));

        }

        [HttpGet]
        [Route("api/[controller]/CreatingProperty/{id}")]

        public IActionResult GetSeasonsByCreatingPropertyId(Guid id)
        {
            var media = _Data.GetSeasonsByCreatingPropertyId(id);
            if (media != null)
            {
                return Ok(media);
            }

            return NotFound($"Season with Id: {id} was not found");
        }

        [HttpGet]
        [Route("api/[controller]/Series/{id}")]

        public IActionResult GetSeasonsBySeriesId(Guid id)
        {
            var media = _Data.GetSeasonsBySeriesId(id);
            if (media != null)
            {
                return Ok(media);
            }

            return NotFound($"Season with Id: {id} was not found");
        }

    }
}
