using Microsoft.AspNetCore.Mvc;
using Work.Models;
using Work.Repositories;

namespace Work.Controllers
{
    public class FinalPageController : Controller
    {
        private readonly FinalPageRepository _finalPageRepository;

        public FinalPageController(FinalPageRepository finalPageRepository)
        {
            _finalPageRepository = finalPageRepository;
        }
        [HttpGet]
        public ActionResult FinalPage()
        {
            List<ProgramDetail> programDetails = _finalPageRepository.GetAllDetails();
            return View(programDetails);
        }
    }
}
