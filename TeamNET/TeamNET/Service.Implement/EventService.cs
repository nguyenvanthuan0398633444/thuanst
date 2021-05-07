using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Respone.Event;
using TeamNET.Repository.Interface;
using TeamNET.Service.Interface;

namespace TeamNET.Service.Implement
{
    public class EventService : IEventService
    {
        private readonly IEventRepository eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }
        public IEnumerable<EventView> Gets()
        {
            return eventRepository.Gets();
        }
    }
}
