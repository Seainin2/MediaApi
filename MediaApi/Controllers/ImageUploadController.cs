using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MediaApi.Controllers
{
    [Route("api/[controller]/{id}")]
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

        public async Task<string> Post([FromForm]FileUploadAPI objFile) 
        {
            try
            {
                if (objFile.file.Length > 0)
                {

                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.file.FileName))
                    {
                        objFile.file.CopyTo(fileStream);
                        fileStream.Flush();

                        return "\\Upload\\" + objFile.file.FileName;
                    }

                }
                else
                {
                    return "Failed";
                }
            }
            catch (Exception e) 
            { 
                return e.Message.ToString();
            }
        }
    }
}
