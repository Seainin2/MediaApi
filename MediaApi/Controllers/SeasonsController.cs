using MediaApi.Data;
using MediaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using static MediaApi.Controllers.ImageUploadController;

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

        public IActionResult AddSeason([FromForm] String data, [FromForm] FileUploadAPI objFile)
        {
            try
            {
                if (objFile.file.Length > 0 && !objFile.Equals(null))
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Season\\"))
                    {

                        Directory.CreateDirectory(_environment.WebRootPath + "\\Season\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Season\\" + objFile.file.FileName))
                    {
                        objFile.file.CopyTo(fileStream);
                        fileStream.Flush();


                        Season season = JsonConvert.DeserializeObject<Season>(data);
                        season.ImageName = objFile.file.FileName;
                        return Ok(_Data.AddSeason(season));
                    }
                }
                else
                {
                    return Ok("Show was NOT!! added, no image");
                }

            }
            catch (Exception e)
            {
                //return Ok(e.Message.ToString());
                return Ok("What??");
            }
        }

    }
}
