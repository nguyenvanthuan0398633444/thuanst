using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Respone.Student
{
    public class StudentView
    {
        public string UserId { get; set; }
        public string StudentCode { get; set; }
        public string StudentName { get; set; }
        public int CourseCurrentId { get; set; }
        public string CourseName { get; set; }
        public string User { get; set; }
    }
}
