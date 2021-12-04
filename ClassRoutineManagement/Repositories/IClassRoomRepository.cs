using ClassRoutineManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Repositories
{
    public interface IClassRoomRepository
    {
        IEnumerable<ClassRoom> GetClassRooms();
        ClassRoom GetClassRoomById(int id);
        ClassRoom SaveClassRoom(ClassRoom obj);
    }
}
