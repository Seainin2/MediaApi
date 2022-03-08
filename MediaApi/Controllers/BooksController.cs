using MediaApi.Data;
using MediaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MediaApi.Controllers
{
    [ApiController]
    public class BooksController : ControllerBase
    {

        private IBookData _bookData;

        public BooksController(IBookData allData)
        {
            _bookData = allData;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetBooks()
        {
            return Ok(_bookData.GetBooks());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetBook(Guid id)
        {
            var movie = _bookData.GetBook(id);
            if (movie != null)
            {
                return Ok(movie);
            }

            return NotFound($"Book with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddBook(Book media)
        {

            return Ok(_bookData.AddBook(media));

        }

        [HttpGet]
        [Route("api/[controller]/CreatingProperty/{id}")]

        public IActionResult GetBooksByCreatingPropertyId(Guid id)
        {
            var media = _bookData.getBooksByCreatingPropertyId(id);
            if (media != null)
            {
                return Ok(media);
            }

            return NotFound($"Book with Id: {id} was not found");
        }

        [HttpGet]
        [Route("api/[controller]/Series/{id}")]

        public IActionResult GetBooksBySeriesId(Guid id)
        {
            var media = _bookData.GetBooksBySeriesId(id);
            if (media != null)
            {
                return Ok(media);
            }

            return NotFound($"Book with Id: {id} was not found");
        }

    }
}
