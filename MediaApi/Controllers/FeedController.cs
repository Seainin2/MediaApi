using Microsoft.AspNetCore.Mvc;

namespace MediaApi.Controllers
{
    [ApiController]
    public class FeedController : Controller
    {
        //private IFeedData _Data;
        public IActionResult Index()
        {
            return View();
        }
    }
}
