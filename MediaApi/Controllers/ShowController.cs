using MediaApi.Data;
using MediaApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using static MediaApi.Controllers.ImageUploadController;

namespace MediaApi.Controllers
{
    [ApiController]
    public class ShowController : Controller
    {
        private IShowData _showData;
        private static IWebHostEnvironment _environment;

        public ShowController(IShowData allData, IWebHostEnvironment environment)
        {
            _environment = environment;
            _showData = allData;
        }
        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetShows()
        {
            return Ok(_showData.GetShows());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetShow(Guid id)
        {
            var show = _showData.GetShow(id);
            if (show != null)
            {
                return Ok(show);
            }

            return NotFound($"Show with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddShow([FromForm] String data, [FromForm] FileUploadAPI objFile) 
        {
            try
            {
                if (objFile.file.Length > 0 && !objFile.Equals(null))
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Show\\"))
                    {

                        Directory.CreateDirectory(_environment.WebRootPath + "\\Show\\");
                    }
                    using FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Show\\" + objFile.file.FileName);
                    objFile.file.CopyTo(fileStream);
                    fileStream.Flush();


                    Show show = JsonConvert.DeserializeObject<Show>(data);
                    show.ImageName = objFile.file.FileName;
                    show.MediaType = "Show";
                    return Ok(_showData.AddShow(show));
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
