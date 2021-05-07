using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Models.Respone.Event
{
    public class EventView
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string Icon { get; set; }
        public string EventContentId { get; set; }
    }
}
