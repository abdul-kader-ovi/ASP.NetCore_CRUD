using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("Subject")]
        public string SubjectName { get; set; }
        [Required]
        [StringLength(6)]
        [DisplayName("Subject Code")]
        public string SubjectCode { get; set; }
        //[DisplayName("Teacher")]
        //public int TeacherId { get; set; }

        public virtual ICollection<ClassRoutine> ClassRoutine { get; set; }
        //public virtual Teacher Teacher { get; set; }
        public virtual List<Teacher> Teachers { get; set; } = new List<Teacher>();

    }
}
