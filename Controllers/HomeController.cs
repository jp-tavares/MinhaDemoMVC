using Microsoft.AspNetCore.Mvc;
using MinhaDemoMVC.Models;
using System.Diagnostics;

namespace MinhaDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string id, Guid categoria)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //return Json("{'nome': 'Eduardo'}");

            //var fileBytes = System.IO.File.ReadAllBytes(@"c:\arquivo.txt");
            //var fileName = "arquivo.txt";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            //return Content("Qualquer coisa");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}