using ClassRoutineManagement.Data;
using ClassRoutineManagement.Models;
using ClassRoutineManagement.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{
    
    public class ClassRoutineRepository: IClassRoutineRepository
    {
        private ApplicationDbContext _context;
        public ClassRoutineRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public ClassRoutine DeleteRoutine(int id)
        {
            ClassRoutine routine = GetClassRoutineById(id);
            if (routine!=null)
            {
                _context.ClassRoutines.Remove(routine);
                _context.SaveChanges();
            }
            return routine;
        }

        public ClassRoutine GetClassRoutineById(int id)
        {
            ClassRoutine classRoutine = _context.ClassRoutines.Find(id);
            
            return classRoutine;
        }

        public IEnumerable<ClassRoutine> GetClassRoutines()
        {
            return _context.ClassRoutines;
        }
        public IEnumerable<ClassRoutineCreateViewModel> GetClassRoutinesViewModel()
        {
            List<ClassRoutineCreateViewModel> classRoutines = _context.ClassRoutines.Select(s => new ClassRoutineCreateViewModel
            {
                Id=s.Id,
                DayOfWeek=s.DayOfWeek,
                StartTime=s.StartTime,
                EndTime=s.EndTime,                
                ClassesId = s.ClassesId,
                CStage=s.Classes.CStage,
                SubjectId=s.SubjectId,
                SubjectName=s.Subject.SubjectName,
                ClassRoomId=s.ClassRoomId,
                RoomNo=s.ClassRoom.RoomNo
            }).ToList();
            return classRoutines;
        }
        public ClassRoutine SaveClassRoutine(ClassRoutine obj)
        {
            _context.ClassRoutines.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public ClassRoutine UpdateRoutine(ClassRoutine upObj)
        {
            var routine = _context.ClassRoutines.Attach(upObj);
            routine.State = EntityState.Modified;
            _context.SaveChanges();
            return upObj;
        }
    }


}
