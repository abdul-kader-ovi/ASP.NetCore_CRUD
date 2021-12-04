using ClassRoutineManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.ViewModels
{
    public class ClassRoutineCreateViewModel
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
        public int ClassesId { get; set; }

        [Required]
        [DisplayName("Class")]
        public string CStage { get; set; }        

        [Required]
        public int SubjectId { get; set; }

        [Required]
        [DisplayName("Subject")]
        public string SubjectName { get; set; }

        [Required]
        [DisplayName("Class Room")]
        public int ClassRoomId { get; set; }

        [Required]
        [DisplayName("Class Room")]
        public string RoomNo { get; set; }
        
    }
}
