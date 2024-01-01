using HastaneRez.Data;
using HastaneRez.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HastaneRez.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult CategoryDetails(int? id)
        {
            var doctors = _db.Doctors.Where(i => i.PoliId == id).ToList();
            ViewBag.KategoriId = id;
            return View(doctors);
        }

        public IActionResult Index()
        {  
            var doctors = _db.Doctors.Where(i=>i.IsHome).ToList();
            return View(doctors);
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
