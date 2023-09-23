using Microsoft.AspNetCore.Mvc;
using Work.Models;
using Work.Repositories;

namespace Work.Controllers
{
    public class AppFormController : Controller
    {
        private readonly IAppFormRepository _appFormRepository;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _environemt;


        public AppFormController(IAppFormRepository appFormRepository, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            _environemt = environment;
            _appFormRepository = appFormRepository;
        }

        [HttpGet]
        public IActionResult AppForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AppForm(AppForm detail, IFormFile img)
        {
            var wwrootPath = _environemt.WebRootPath + "/AppFormPictures";
            Guid guid = Guid.NewGuid();
            string fullPath = System.IO.Path.Combine(wwrootPath, guid + img.FileName);
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                img.CopyTo(fileStream);
            };
            detail.img = guid + img.FileName;
            _appFormRepository.Create(detail);
            List<AppForm> programdetail = _appFormRepository.GetAllDetails();
            return RedirectToAction("WorkFlow", programdetail);
        }
    }
}
