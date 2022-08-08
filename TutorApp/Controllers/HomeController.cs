using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using TutorApp.DAL;
using TutorApp.Models;
using TutorApp.Repositories.Interfaces;

namespace TutorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DbWebContext _context;
        private readonly ITutorRepository _tutorRepository;

        public HomeController(ILogger<HomeController> logger, DbWebContext context, ITutorRepository tutorRepository)
        {
            _logger = logger;
            _context = context;
            _tutorRepository = tutorRepository;
        }

        public IActionResult Index()
        {
            var result = _tutorRepository.GetTutorsData().FirstOrDefault().Name;
            
            System.Diagnostics.Debug.WriteLine("resultat repository tutor: " + result);

            return View();
        }

        public ActionResult GetTutorId()
        {

            var result = _tutorRepository.GetTutorsDataByID(1);
            return Json(result);

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