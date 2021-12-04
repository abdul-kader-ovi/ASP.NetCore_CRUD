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
    public class ClassRoomController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IClassRoomRepository _classRoomRepository;

        public ClassRoomController(IClassRoomRepository classRoomRepository, IWebHostEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
            this._classRoomRepository = classRoomRepository;
        }

        public IActionResult Index()
        {
            List<ClassRoom> list = _classRoomRepository.GetClassRooms().ToList();
            return View(list);
        }

        public IActionResult CreateClassRoom()
        {
            return PartialView("_CreateClassRoomPartial");
        }

        [HttpPost]
        public IActionResult CreateClassRoom(ClassRoom obj)
        {
            ClassRoom classRoom = new ClassRoom
            {
                RoomNo = obj.RoomNo
            };
            if (ModelState.IsValid)
            {
                _classRoomRepository.SaveClassRoom(classRoom);
                return RedirectToAction("Index");
            }
            return View(classRoom);
        }
    }
}
