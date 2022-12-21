using Microsoft.AspNetCore.Mvc;

namespace StateProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet(nameof(Index)),HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
