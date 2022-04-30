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
    public class GamesController : ControllerBase
    {

        private IGameData _Data;
        private static IWebHostEnvironment _environment;

        public GamesController(IGameData allData,IWebHostEnvironment environment)
        {
            _environment = environment;
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

        public IActionResult AddGame([FromForm] String data, [FromForm] FileUploadAPI objFile)
        {
            try
            {
                if (objFile.file.Length > 0 && !objFile.Equals(null))
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Game\\"))
                    {

                        Directory.CreateDirectory(_environment.WebRootPath + "\\Game\\");
                    }
                    using FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Game\\" + objFile.file.FileName);
                    objFile.file.CopyTo(fileStream);
                    fileStream.Flush();


                    Game game = JsonConvert.DeserializeObject<Game>(data);
                    game.ImageName = objFile.file.FileName;
                    game.MediaType = "Game";
                    return Ok(_Data.AddGame(game));
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
