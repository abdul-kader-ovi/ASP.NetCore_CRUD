using ClassRoutineManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{ 
    public interface IClassesRepository
    {
        IEnumerable<Classes> GetClasses();
        Classes GetClassesById(int id);
        Classes SaveClasses(Classes obj);
    }
}
