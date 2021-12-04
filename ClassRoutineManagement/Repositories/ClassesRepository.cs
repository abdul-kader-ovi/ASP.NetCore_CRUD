using ClassRoutineManagement.Data;
using ClassRoutineManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{
    public class ClassesRepository : IClassesRepository
    {
        private readonly ApplicationDbContext _context;
        public ClassesRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<Classes> GetClasses()
        {
            return _context.Classes;
        }

        public Classes GetClassesById(int id)
        {
            Classes classes = _context.Classes.Find(id);
            return classes;
        }

        public Classes SaveClasses(Classes obj)
        {
            _context.Classes.Add(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}
