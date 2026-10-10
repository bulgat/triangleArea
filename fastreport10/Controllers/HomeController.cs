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

        [System.Diagnostics.Conditional("DEBUG")]
        static void ShowDebugInfo(string message)
        {
#line hidden
            System.Diagnostics.Debug.WriteLine("test = " + message.ToString());
        }
        public IActionResult Log()
        {
            var middle = new List<int> { 1, 5, 7, 90 }.Average();
            ViewBag.middle = middle;

            return View();
        }
        public IActionResult Index()
        {
            ShowDebugInfo("string kol");

            #pragma warning disable
            RunOldInternalLogic();
            #pragma warning restore

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            var report = new WebReport();
            var data = new DataSet();
            data.ReadXml(Path.Combine(userProfile, "Documents", "nwind.xml"));
            report.Report.RegisterData(data);
            report.Report.Load(Path.Combine(userProfile, "Documents", "Simple List.frx"));
            ViewBag.WebReport = report;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Obsolete("Используйте RunModernLogic вместо этого метода")]
        static void RunOldInternalLogic() { /* ... */ }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
