using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Teacher")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Email")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage ="Invalid Email Formate")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Qualification")]
        public string Qualification { get; set; }

        [Required]
        [ForeignKey("Subject")]//very important
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; private set; }
        //public virtual ICollection<ClassRoutine> ClassRoutines { get; set; }
    }
}
