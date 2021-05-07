using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.EventContent;

namespace TeamNET.Models.Respone.Student
{
    public class StudentDetailsView : EventContentView
    {
        public string  StudentId { get; set; }
        public string FullName { get; set; }
       

    }
}
