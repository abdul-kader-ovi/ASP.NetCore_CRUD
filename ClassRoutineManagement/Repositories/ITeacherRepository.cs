using ClassRoutineManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacherById(int id);
        Teacher SaveTeacher(Teacher obj);
    }
}
