using ClassRoutineManagement.Models;
using ClassRoutineManagement.Repositories;
using ClassRoutineManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository, IWebHostEnvironment hostingEnvironment)
        {
            this._teacherRepository = teacherRepository;
            this._hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            List<Teacher> list = _teacherRepository.GetAllTeachers().ToList();
            return View(list);
        }



        //[HttpGet]
        //public IActionResult CreateTeacher()
        //{
        //    return PartialView("_TeacherCreatePartial");
        //}

        //[HttpPost]
        //public IActionResult CreateTeacher(TeacherCreateViewModel obj)
        //{
        //    //string uniqueFileName = ProcessFileUpload(obj);
        //    Teacher teacher = new Teacher
        //    {
        //        Name = obj.Name,
        //        Email = obj.Email,
        //        Qualification=obj.Qualification,
        //        //PhotoPath= uniqueFileName
        //    };
        //    if (ModelState.IsValid)
        //    {
        //        _teacherRepository.SaveTeacher(teacher);
        //        return RedirectToAction("Index");
        //    }
        //    return PartialView("_TeacherCreatePartial");
        //}

        //private string ProcessFileUpload(TeacherCreateViewModel obj)
        //{
        //    string uniqueFileName = null;
        //    if (obj.Photo != null)
        //    {
        //        string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + obj.Photo.FileName;
        //        string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            obj.Photo.CopyTo(fileStream);
        //        }
        //    }
        //    return uniqueFileName;
        //}

        [HttpGet]
        public IActionResult Details(int id)
        {
            Teacher teacher = _teacherRepository.GetTeacherById(id);
            return View(teacher);
        }

    }
}
