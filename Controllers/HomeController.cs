using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using TriangleDocker.dataBasa;
using TriangleDocker.Models;

namespace TriangleDocker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDBcontent _context;

        public HomeController(ILogger<HomeController> logger, AppDBcontent context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var scoreList = _context.Score.ToList();
            return View();
        }

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
