using MediaApi.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MediaApi.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {

        private IFeedData _data;
        private static IWebHostEnvironment _environment;

        public MainController(IFeedData allData, IWebHostEnvironment enviroment)
        {
            _environment = enviroment;
            _data = allData;
        }

        [HttpGet]
        [Route("api/[controller]/{{value}}")]

        public IActionResult GetBooks(String value)
        {
            switch (value)
            {
                case "Movie":
                    return Ok();
            }
            return Ok();
        }
    }
}
