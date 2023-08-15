using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzManagement
{
    internal class Performance
    {
        public int AthleteId { get; set; }
        public int EventId { get; set; }
        public int Score { get; set; }
        public TimeOnly Time { get; set; }

        public Performance(int athleteId, int eventId, int score, TimeOnly time)
        {
            AthleteId = athleteId;
            EventId = eventId;
            Score = score;
            Time = time;
        }
    }
}
