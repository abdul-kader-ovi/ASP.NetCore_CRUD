using ClassRoutineManagement.Models;
using ClassRoutineManagement.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Controllers
{
    public class ClassesController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IClassesRepository _classesRepository;
        public ClassesController(IClassesRepository classesRepository, IWebHostEnvironment hostingEnvironment)
        {
            this._classesRepository = classesRepository;
            this._hostingEnvironment = hostingEnvironment;
        }
        
        public IActionResult Index()
        {
            List<Classes> list = _classesRepository.GetClasses().ToList();
            return View(list);
        }

        public IActionResult CreateClasses()
        {
            return PartialView("_CreateClassesPartial");
        }

        [HttpPost]
        public IActionResult CreateClasses(Classes obj)
        {
            Classes classes = new Classes
            {
                CStage = obj.CStage
            };

            if (ModelState.IsValid)
            {
                _classesRepository.SaveClasses(classes);
                return RedirectToAction("Index");
            }
            return PartialView("_CreateClassesPartial");
        }

        
    }
}
