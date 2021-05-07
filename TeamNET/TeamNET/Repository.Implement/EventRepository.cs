using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models;
using TeamNET.Models.Respone.Event;
using TeamNET.Repository.Interface;

namespace TeamNET.Repository.Implement
{
    public class EventRepository : IEventRepository
    {
        private readonly OJTDbContext context;

        public EventRepository(OJTDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<EventView> Gets()
        
        {
            IEnumerable<EventView> events = new List<EventView>();
            try
            {
                events = (from e in context.Events
                            select (new EventView()
                            {
                                EventId = e.EventId,
                                EventName = e.EventName,
                                Icon = e.Icon
                            }));
                return events;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
