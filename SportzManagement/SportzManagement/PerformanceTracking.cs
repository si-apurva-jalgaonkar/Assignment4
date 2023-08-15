using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzManagement
{
    internal class PerformanceTracking
    {
        EventManagement eventManagement = null;

        private Dictionary<int, Dictionary<int, object>> athletePerformance = new Dictionary<int, Dictionary<int, object>>();
        public void RecordAthletePerformance(int athleteId, int eventId, object performanceData)
        {
            if (!athletePerformance.ContainsKey(athleteId))
            {
                athletePerformance[athleteId] = new Dictionary<int, object>();
            }
            athletePerformance[athleteId][eventId] = performanceData;
        }

        public string ViewAthletePerformance(int athleteId, int eventId)
        {
            if (athletePerformance.ContainsKey(athleteId) && athletePerformance[athleteId].ContainsKey(eventId))
            {
                return $"Performance data: {athletePerformance[athleteId][eventId]}";
            }
            else
            {
                return "Performance data not found.";
            }
        }

        public Dictionary<string, object> GetAthletePerformanceInAllEvents(int athleteId)
        {
            if (athletePerformance.ContainsKey(athleteId))
            {
                var athleteData = athletePerformance[athleteId];
                Dictionary<string, object> performanceInAllEvents = new Dictionary<string, object>();
                foreach (var entry in athleteData)
                {
                    int eventId = entry.Key;
                    Event ev = eventManagement.events.FirstOrDefault(e => e.EventId == eventId);
                    if (ev != null)
                    {
                        performanceInAllEvents[ev.EventName] = entry.Value;
                    }
                }
                return performanceInAllEvents;
            }
            else
            {
                return null;
            }
        }
    }
}

    

