using MediaApi.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MediaApi.Controllers
{
    [ApiController]
    public class FeedController : Controller
    {
        private IFeedData _Data;

        public FeedController(IFeedData data)
        {
            _Data = data;
        }
        [HttpGet]
        [Route("api/[controller]/{search}")]

        public IActionResult GetFeed([FromForm] String data, String search)
        {
            List<String> mediaTypes = JsonConvert.DeserializeObject<List<String>>(data);
            return Ok(_Data.GetAllMedia(mediaTypes,search));
        }
    
    }
}
