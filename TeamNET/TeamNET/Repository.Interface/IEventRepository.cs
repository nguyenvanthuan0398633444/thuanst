using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Event;

namespace TeamNET.Repository.Interface
{
    public interface IEventRepository
    {
        IEnumerable<EventView> Gets();
    }
}
