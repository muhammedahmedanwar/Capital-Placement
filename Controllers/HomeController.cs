using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Diagnostics;
using Work.Models;
using Work.Repositories;

namespace Work.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ProgramDetail detail)
        {
            _homeRepository.Create(detail);
            List<ProgramDetail> programdetail = _homeRepository.GetAllDetails();
            return RedirectToAction("AppForm", programdetail);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}