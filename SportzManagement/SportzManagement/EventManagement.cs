using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzManagement
{
    internal class EventManagement
    {
        public List<Event> events = new List<Event>();
        public int CreateEvent(string eventName, string eventType, DateTime eventDate)
        {
            Event newEvent = new Event(eventName, eventType, eventDate);
            events.Add(newEvent);
            Console.WriteLine("Event Added Successfully");
            return newEvent.EventId;
        }

        public string ViewEventDetails(int eventId)
        {
            Event ev = events.FirstOrDefault(a => a.EventId == eventId);
            if (ev != null)
            {
                return $"Event Name: {ev.EventName}\nEvent Type: {ev.EventType}\nEvent Date : {ev.EventDate}";
            }
            else
            {
                return "Event Not Found";
            }
        }

        public string UpdateEventDetails(int eventId, string eventName, string eventType, DateTime eventDate)
        {
            Event ev = events.FirstOrDefault(a => a.EventId == eventId);
            if (ev != null)
            {
                ev.EventName = eventName;
                ev.EventType = eventType;
                ev.EventDate = eventDate;
                return "Updated Sucessfully";
            }
            else
            {
                return "Event not found";
            }
        }


        public string RemoveEvent(int eventId)
        {
            Event ev = events.FirstOrDefault(a => a.EventId == eventId);
            if (ev != null)
            {
                events.Remove(ev);
                return "Event removed sucessfully";
            }
            else
            {
                return "Event not found";
            }
        }

        public List<Event> GetEventsByType(string eventType)
        {
            return events.Where(a => a.EventType == eventType).ToList();

        }

        public List<Event> GetUpcomingEvents()
        {
            DateTime currentDate = DateTime.Now;
            return events.Where(e => e.EventDate > currentDate).ToList();
        }
    }
}

    

