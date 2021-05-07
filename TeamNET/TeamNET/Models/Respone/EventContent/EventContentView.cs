using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Respone.EventContent
{
    public class EventContentView
    {
        public int EventContentId { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventIcon { get; set; }
        
        public int CourseCurrentId { get; set; }
        public string CourseName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int CountNotification { get; set; }
    }
}
