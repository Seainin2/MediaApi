using MediaApi.Data;
using MediaApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using static MediaApi.Controllers.ImageUploadController;

namespace MediaApi.Controllers
{
    
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private IMovieData _movieData;
        private static IWebHostEnvironment _environment;

        public MoviesController(IMovieData allData, IWebHostEnvironment environment) 
        {
            _environment = environment;
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

        public IActionResult AddMovie([FromForm]String data, [FromForm]FileUploadAPI objFile)
        {
            try
            {
                if (objFile.file.Length > 0 && !objFile.Equals(null))
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Movie\\"))
                    {

                        Directory.CreateDirectory(_environment.WebRootPath + "\\Movie\\");
                    }
                    using FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Movie\\" + objFile.file.FileName);
                    objFile.file.CopyTo(fileStream);
                    fileStream.Flush();


                    Movie movie = JsonConvert.DeserializeObject<Movie>(data);
                    movie.ImageName = objFile.file.FileName;
                    movie.MediaType = "Movie";
                    return Ok(_movieData.AddMovie(movie));
                }
                else
                {
                    return Ok("Movie was NOT!! added, no image");
                }

            } catch (Exception e)
            {
                return Ok(e.Message.ToString());
                
            }

            

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
