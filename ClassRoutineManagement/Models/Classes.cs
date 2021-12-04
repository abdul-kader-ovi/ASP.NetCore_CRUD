using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.Models
{
    public class Classes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Class")]
        public string CStage { get; set; }

        public virtual ICollection<ClassRoutine> ClassRoutines { get; set; }
    }
}
