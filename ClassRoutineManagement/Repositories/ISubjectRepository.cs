using ClassRoutineManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{

    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAllSubjects();
        Subject GetSubjectById(int id);
        Subject SaveSubject(Subject obj);
    }
}
