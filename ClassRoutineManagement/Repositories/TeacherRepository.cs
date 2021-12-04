using ClassRoutineManagement.Data;
using ClassRoutineManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext _context;
        public TeacherRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _context.Teachers;
        }

        public Teacher GetTeacherById(int id)
        {
            Teacher teacher = _context.Teachers.Find(id);
            return teacher;
        }

        public Teacher SaveTeacher(Teacher obj)
        {
            _context.Teachers.Add(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}
