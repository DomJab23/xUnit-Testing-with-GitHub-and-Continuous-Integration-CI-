using System.Collections.Generic;
using System.Linq;

namespace MyEvents
{
    public class EventManager
    {
        private List<Event> events = new();

        public void AddEvent(Event newEvent)
        {
            events.Add(newEvent);
        }

        public Event GetEvent(string name)
        {
            return events.FirstOrDefault(e => e.Name == name);
        }

        public bool CancelEvent(string name)
        {
            var evnt = GetEvent(name);
            if (evnt != null && evnt.IsActive)
            {
                evnt.Cancel();
                return true;
            }
            return false;
        }
    }
}