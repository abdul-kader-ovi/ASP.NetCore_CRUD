using ClassRoutineManagement.Data;
using ClassRoutineManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{
    
    public class SubjectRepository : ISubjectRepository
    {
        private readonly ApplicationDbContext _context;
        public SubjectRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<Subject> GetAllSubjects()
        {
            return _context.Subjects;
        }

        public Subject GetSubjectById(int id)
        {
            Subject subject = _context.Subjects.Find(id);
            return subject;
        }

        public Subject SaveSubject(Subject obj)
        {
            _context.Subjects.Add(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}
