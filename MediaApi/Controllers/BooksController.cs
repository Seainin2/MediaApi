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
    public class BooksController : ControllerBase
    {

        private IBookData _bookData;
        private static IWebHostEnvironment _environment;

        public BooksController(IBookData allData, IWebHostEnvironment enviroment)
        {
            _environment = enviroment;
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

        public IActionResult AddBook([FromForm] String data, [FromForm] FileUploadAPI objFile)
        {
            try
            {
                if (objFile.file.Length > 0 && !objFile.Equals(null))
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Book\\"))
                    {

                        Directory.CreateDirectory(_environment.WebRootPath + "\\Book\\");
                    }
                    using FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Book\\" + objFile.file.FileName);
                    objFile.file.CopyTo(fileStream);
                    fileStream.Flush();


                    Book book = JsonConvert.DeserializeObject<Book>(data);
                    book.ImageName = objFile.file.FileName;
                    book.MediaType = "Book";
                    return Ok(_bookData.AddBook(book));
                }
                else
                {
                    return Ok("Show was NOT!! added, no image");
                }

            }
            catch (Exception e)
            {
                return Ok(e.Message.ToString());
            }
        }


    }
}
