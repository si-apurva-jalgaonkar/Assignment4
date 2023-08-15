using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzManagement
{
    internal class Event
    {
        private static int nextEventId = 1;
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }


        public Event(string eventName, string eventType, DateTime eventDate)
        {
            EventId = nextEventId++;
            EventName = eventName;
            EventType = eventType;
            EventDate = eventDate;
        }

        public override string ToString()
        {
            return $"Event Name:{EventName}\t Event Type:{EventType}\t Event Date:{EventDate}";
        }
    }
}
