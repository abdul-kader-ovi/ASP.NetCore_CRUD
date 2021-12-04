using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassRoutineManagement.ViewModels
{
    public class TeacherCreateViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Teacher")]
        public string Name { get; set; }
        [DisplayName("Email")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Qualification")]
        public string Qualification { get; set; }
    }
}
