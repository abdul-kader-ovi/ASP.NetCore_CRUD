using ClassRoutineManagement.Data;
using ClassRoutineManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{
    public class ClassRoomRepository : IClassRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public ClassRoomRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public ClassRoom GetClassRoomById(int id)
        {
            ClassRoom classRoom = _context.ClassRooms.Find(id);
            return classRoom;
        }

        public IEnumerable<ClassRoom> GetClassRooms()
        {
            return _context.ClassRooms;
        }

        public ClassRoom SaveClassRoom(ClassRoom obj)
        {
            _context.ClassRooms.Add(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}
