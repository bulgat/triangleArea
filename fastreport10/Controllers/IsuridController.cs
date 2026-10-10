using FastReport.Web;
using fastreport10.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace fastreport10.Controllers
{
    public class IsuridController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IsuridController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Logging()
        {
            var middle = new List<int> { 1, 5, 7, 90 }.Average();
            ViewBag.middle = middle;
            int max = (int)middle;
            //checked
            //{
                max = int.MaxValue; // 2147483647
                int result = max + 1;
            //}
            ViewBag.max = max;
            return View();
        }
        
    }
}
