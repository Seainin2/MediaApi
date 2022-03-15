using MediaApi.Data;
using MediaApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using static MediaApi.Controllers.ImageUploadController;

namespace MediaApi.Controllers
{
    
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private IMovieData _movieData;

        public MoviesController(IMovieData allData) 
        {
            _movieData = allData;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetMovies()
        {
            return Ok(_movieData.GetMovies());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetMovie(Guid id)
        {
            var movie = _movieData.GetMovie(id);
            if (movie != null)
            {
                return Ok(movie);
            }

            return NotFound($"Movie with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddMovie(Movie movie, [FromForm] FileUploadAPI objFile)
        {

            return Ok(_movieData.AddMovie(movie));

        }

        [HttpGet]
        [Route("api/[controller]/CreatingProperty/{id}")]

        public IActionResult GetMoviesByCreatingPropertyId(Guid id) {
            var movie = _movieData.getMoviesByCreatingPropertyId(id);
            if (movie != null)
            {
                return Ok(movie);
            }

            return NotFound($"Movie with Id: {id} was not found");
        }

        [HttpGet]
        [Route("api/[controller]/Series/{id}")]

        public IActionResult GetMoviesBySeriesId(Guid id)
        {
            var movie = _movieData.GetMoviesBySeriesId(id);
            if (movie != null)
            {
                return Ok(movie);
            }

            return NotFound($"Movie with Id: {id} was not found");
        }

    }
}
