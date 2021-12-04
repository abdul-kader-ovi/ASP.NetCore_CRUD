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
    public class SubjectController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private ISubjectRepository _subjectRepositiory;
        private ITeacherRepository _teacherRepository;
        public SubjectController(ISubjectRepository subjectRepositiory, IWebHostEnvironment hostingEnvironment, ITeacherRepository teacherRepository)
        {
            this._hostingEnvironment = hostingEnvironment;
            this._subjectRepositiory = subjectRepositiory;
            this._teacherRepository = teacherRepository;
        }
        public IActionResult Index()
        {
            List<Subject> list = _subjectRepositiory.GetAllSubjects().ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Subject subject = new Subject();
            subject.Teachers.Add(new Teacher() { Id = 1 });
            return View(subject);
        }

        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            //Subject subject = new Subject
            //{
            //    SubjectName = obj.SubjectName,
            //    SubjectCode = obj.SubjectCode,
            //    TeacherId=obj.TeacherId
            //};

            foreach (Teacher teacher in subject.Teachers)
            {
                if (teacher.Name==null||teacher.Name.Length==0)
                {
                    subject.Teachers.Remove(teacher);
                }
            }
            _subjectRepositiory.SaveSubject(subject);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Teacher teacher = _teacherRepository.GetTeacherById(id);
            return View(teacher);
        }

    }
}
