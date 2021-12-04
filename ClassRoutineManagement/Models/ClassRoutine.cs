using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Models
{
    public class ClassRoutine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Day")]
        public string DayOfWeek { get; set; }
        [Required]
        [DisplayName("Start Time")]
        public TimeSpan StartTime { get; set; }
        [Required]
        [DisplayName("End Time")]
        public TimeSpan EndTime { get; set; }
        
        [Required]
        [DisplayName("Class")]
        public int ClassesId { get; set; }
        [DisplayName("Subject")]
        public int SubjectId { get; set; }
       
        [Required]
        [DisplayName("Class Room")]
        public int ClassRoomId { get; set; }

        public virtual Subject Subject { get; set; }       
        public virtual ClassRoom ClassRoom { get; set; }
        public virtual Classes Classes { get; set; }
    }
}
