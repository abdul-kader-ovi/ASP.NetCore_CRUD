using ClassRoutineManagement.Data;
using ClassRoutineManagement.Models;
using ClassRoutineManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{
    
    public interface IClassRoutineRepository
    {
        IEnumerable<ClassRoutine> GetClassRoutines();
        ClassRoutine GetClassRoutineById(int id);
        ClassRoutine SaveClassRoutine(ClassRoutine obj);
        ClassRoutine UpdateRoutine(ClassRoutine upObj);
        ClassRoutine DeleteRoutine(int id);
        IEnumerable <ClassRoutineCreateViewModel> GetClassRoutinesViewModel();

    }
}
