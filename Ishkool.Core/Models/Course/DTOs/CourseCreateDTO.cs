using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishkool.Core.Models.Course.DTOs
{
    public class CourseCreateDTO
    {

        [Required]
        public string CourseCode { get; set; }

        [Required]
        [MaxLength(50)]

        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public CourseType CourseType { get; set; }
    }
}
