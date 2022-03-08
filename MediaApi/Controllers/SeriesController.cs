using MediaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MediaApi.Data
{
    [ApiController]
    public class SeriesController : ControllerBase
    {

        private ISeriesData _Data;

        public SeriesController(ISeriesData allData)
        {
            _Data = allData;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetSeries()
        {
            return Ok(_Data.GetSeries());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetSeries(Guid id)
        {
            var media = _Data.getSeries(id);
            if (media != null)
            {
                return Ok(media);
            }

            return NotFound($"Series with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddSeries(Series series)
        {

            return Ok(_Data.AddSeries(series));

        }


    }
}