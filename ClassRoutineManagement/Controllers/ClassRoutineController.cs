using ClassRoutineManagement.Data;
using ClassRoutineManagement.Models;
using ClassRoutineManagement.Repositories;
using ClassRoutineManagement.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Controllers
{
    public class ClassRoutineController : Controller
    {
       
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IClassRoutineRepository _classRoutineRepository;
        private ISubjectRepository _subjectRepository;
        private IClassesRepository _classesRepository;
        private IClassRoomRepository _classRoomRepository;
        public ClassRoutineController(IClassRoutineRepository classRoutineRepository, IClassRoomRepository classRoomRepository, IClassesRepository classesRepository,  ISubjectRepository subjectRepository, IWebHostEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
            this._classRoutineRepository = classRoutineRepository;
            this._classesRepository = classesRepository;
            this._subjectRepository = subjectRepository;
            this._classRoomRepository = classRoomRepository;
        }

        

        public IActionResult Index(string searchText = "", int pg = 1)
        {
            //ViewBag.Doctors = _patientRepository.GetAllDoctor();
            //ViewBag.Cities = _context.Cities;
            List<ClassRoutineCreateViewModel> list;

            //for Searching
            if (searchText != "" && searchText != null)
            {
                list = _classRoutineRepository.GetClassRoutinesViewModel().Where(p => p.CStage.Contains(searchText)).ToList();
            }
            else
            {
                list = _classRoutineRepository.GetClassRoutinesViewModel().Where(p => p.CStage.Contains(searchText)).ToList();
            }
            //forPaging
            const int pageSize = 3;
            if (pg < 1)
            {
                pg = 1;
            }
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;

            //return View(applicants);
            return View(data);

        }

        public IActionResult CreateClassRoutine()
        {
           
            ViewBag.Subjects = _subjectRepository.GetAllSubjects().ToList();
            ViewBag.Classes = _classesRepository.GetClasses().ToList();
            ViewBag.ClassRooms = _classRoomRepository.GetClassRooms().ToList();
            return PartialView("_CreateClassRoutinePartial");
        }

        [HttpPost]
        public IActionResult CreateClassRoutine(ClassRoutineCreateViewModel obj)
        {                       
            ClassRoutine classRoutine = new ClassRoutine
            {
                DayOfWeek = obj.DayOfWeek,
                StartTime = obj.StartTime,
                EndTime = obj.EndTime,                
                ClassesId = obj.ClassesId,
                SubjectId=obj.SubjectId,
                ClassRoomId=obj.ClassRoomId
            };                    
            _classRoutineRepository.SaveClassRoutine(classRoutine);                        
            return RedirectToAction("Index");
        }
       
        public IActionResult Edit(int id)
        {
            ViewBag.Subjects = _subjectRepository.GetAllSubjects().ToList();
            ViewBag.Classes = _classesRepository.GetClasses().ToList();
            ViewBag.ClassRooms = _classRoomRepository.GetClassRooms().ToList();
            ClassRoutine classRoutine = _classRoutineRepository.GetClassRoutineById(id);
            ClassRoutineCreateViewModel viewModel = GetEditRoutine(classRoutine);
            return PartialView("_EditRoutinePartial", viewModel);
        }

        private ClassRoutineCreateViewModel GetEditRoutine(ClassRoutine obj)
        {
            
            ClassRoutineCreateViewModel editRoutine = new ClassRoutineCreateViewModel
            {
                Id = obj.Id,
                DayOfWeek = obj.DayOfWeek,
                StartTime = obj.StartTime,
                EndTime = obj.EndTime,                
                ClassesId = obj.ClassesId,
                SubjectId=obj.SubjectId,
                ClassRoomId=obj.ClassRoomId
            };
            return editRoutine;
        }

        [HttpPost]
        public IActionResult Edit(ClassRoutineCreateViewModel obj)
        {
            ClassRoutine routine = _classRoutineRepository.GetClassRoutineById(obj.Id);            
            
            
                routine.DayOfWeek = obj.DayOfWeek;
                routine.StartTime = obj.StartTime;
                routine.EndTime = obj.EndTime; 
                routine.ClassesId = obj.ClassesId;
                routine.SubjectId = obj.SubjectId;
                routine.ClassRoomId = obj.ClassRoomId;
                ClassRoutine crt = _classRoutineRepository.UpdateRoutine(routine);

                return RedirectToAction("Index");
            
            //ClassRoutineCreateViewModel viewModel = GetEditRoutine(routine);
            //return View(viewModel);
        }

        //[HttpGet]
        //public IActionResult Details(int id)
        //{
        //    ClassRoutine classRoutine = _classRoutineRepository.GetClassRoutineById(id);
        //    return PartialView("_ClassRoutineDetailsPartial", classRoutine);
        //}

        [HttpGet]
        public IActionResult Delete(int id)
        {
            ClassRoutine routine = _classRoutineRepository.GetClassRoutineById(id);
            ClassRoutineCreateViewModel viewModel = GetEditRoutine(routine);
            return PartialView("_DeleteClassRoutinePartial", viewModel);
            //return View(viewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
                            
            ClassRoutine rtn = _classRoutineRepository.DeleteRoutine(id);

            return RedirectToAction("Index");
          
        }
    }
}
