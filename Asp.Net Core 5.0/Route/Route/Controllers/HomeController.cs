using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Route.Models;
using System.Diagnostics;

namespace Route.Controllers
{
    //attribute ---  mapdefaultcontroller eklemeyi unutmuyoruz. Startup dosyasına
    //[Route("[controller]/[action]")]
    // Custom attribute
    //[Route("ana/[action]")]
    [Route("ana")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("in/{id:int?}")]
        public IActionResult Index(int? id, string x, int y)
        {
            return View();
        }

        [Route("action")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
