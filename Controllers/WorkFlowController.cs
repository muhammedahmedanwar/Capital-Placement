using Microsoft.AspNetCore.Mvc;
using Work.Models;
using Work.Repositories;

namespace Work.Controllers
{
    public class WorkFlowController : Controller
    {
        private readonly WorkFlowRepository _workFlowRepository;

        public WorkFlowController(WorkFlowRepository workFlowRepository)
        {
            _workFlowRepository = workFlowRepository;
        }

        [HttpGet]
        public IActionResult WorkFlow()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WorkFlow(WorkFlow workflows)
        {
            _workFlowRepository.Create(workflows);
            List<WorkFlow> work = _workFlowRepository.GetAllWorks();
            return RedirectToAction("FinalPage", work);
        }
    }
}
