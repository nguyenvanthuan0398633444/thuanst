using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Request.Student
{
    public class ReqSearchEvent
    {
        public string StudentId { get; set; }
        public string UserCurrentId { get; set; }
        public int CourseId { get; set; }
        public int EventId { get; set; }
        public List<int> Statuses { get; set; }
    }
}
