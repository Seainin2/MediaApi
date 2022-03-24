using MediaApi.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using static MediaApi.Controllers.ImageUploadController;

namespace MediaApi.Data
{
    [ApiController]
    public class SeriesController : ControllerBase
    {

        private ISeriesData _Data;
        private static IWebHostEnvironment _environment;

        public SeriesController(ISeriesData allData, IWebHostEnvironment environment)
        {
            _environment = environment;
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

        public IActionResult AddSeries([FromForm] String data, [FromForm] FileUploadAPI objFile)
        {
            try
            {
                if (objFile.file.Length > 0 && !objFile.Equals(null))
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Series\\"))
                    {

                        Directory.CreateDirectory(_environment.WebRootPath + "\\Series\\");
                    }
                    using FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Series\\" + objFile.file.FileName);
                    objFile.file.CopyTo(fileStream);
                    fileStream.Flush();


                    Series series = JsonConvert.DeserializeObject<Series>(data);
                    series.ImageName = objFile.file.FileName;
                    series.MediaType = "Series";
                    return Ok(_Data.AddSeries(series));
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