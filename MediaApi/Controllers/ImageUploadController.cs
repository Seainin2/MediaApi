using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MediaApi.Controllers
{

    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        public static IWebHostEnvironment _environment;

        public ImageUploadController(IWebHostEnvironment environment)
        { 
            _environment = environment;
        }

        public class FileUploadAPI 
        { 
            public IFormFile file { get; set; }
        }
        [HttpPost]
        [Route("api/[controller]/filepath={filepath}&id={id}")]
        public IActionResult AddImage(Guid id,String filepath, [FromForm]FileUploadAPI objFile) 
        {
            try
            {
                if (objFile.file.Length > 0)
                {

                    if (!Directory.Exists(_environment.WebRootPath + filepath))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + filepath);
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + filepath + objFile.file.FileName))
                    {
                        objFile.file.CopyTo(fileStream);
                        fileStream.Flush();

                        return Ok(filepath + objFile.file.FileName);
                    }

                }
                else
                {
                    return BadRequest("No Image");
                }
            }
            catch (Exception e) 
            { 
                return BadRequest(e.Message.ToString());
            }
        }
    }
}
