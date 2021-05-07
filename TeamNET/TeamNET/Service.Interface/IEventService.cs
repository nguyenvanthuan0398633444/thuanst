using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Event;

namespace TeamNET.Service.Interface
{
    public interface IEventService
    {
        IEnumerable<EventView> Gets();
    }
}
