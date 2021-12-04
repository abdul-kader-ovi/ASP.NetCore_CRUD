using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Models
{
    public class ClassRoom
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Room No")]
        public string RoomNo { get; set; }    
        
        public virtual ICollection<ClassRoutine> ClassRoutine { get; set; }        
    }
}
