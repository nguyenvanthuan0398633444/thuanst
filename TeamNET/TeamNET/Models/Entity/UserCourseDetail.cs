using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Entity
{
    public class UserCourseDetail
    {
        [Key]
        public int CourseCurrentId { get; set; }
        public string TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public ApplicationUser Teacher { get; set; }
        public string DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public ApplicationUser Doctor { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
