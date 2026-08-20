using FastReport.Web;
using fastreport10.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace fastreport10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var report = new WebReport();
            var data = new DataSet();
            data.ReadXml($"C:/Users/Finally/Documents/nwind.xml");
            report.Report.RegisterData(data);
            report.Report.Load($"C:/Users/Finally/Documents/Simple List.frx");
            ViewBag.WebReport = report;
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
