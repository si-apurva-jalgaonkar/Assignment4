namespace SportzManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AthleteManagement athleteManagement = new AthleteManagement();
            int athlete1 = athleteManagement.RegisterAthlete("PV", "Sindhu", 28, "Badminton", DateTime.Now.AddYears(-13));
            int athlete2 = athleteManagement.RegisterAthlete("Pradeep", "Narval", 26, "Kabaddi", DateTime.Now.AddYears(-10));
            int athlete3 = athleteManagement.RegisterAthlete("Nihal", "Sarin", 19, "Chess", DateTime.Now.AddYears(-7));
            int athlete4 = athleteManagement.RegisterAthlete("Sunil", "Chhetri", 39, "Football", DateTime.Now.AddYears(-18));
            int athlete5 = athleteManagement.RegisterAthlete("Hardik", "Pandya", 29, "Cricket", DateTime.Now.AddYears(-19));


            Console.WriteLine(athleteManagement.ViewAthleteDetails(2));

            //athlete age changed
            athleteManagement.UpdateAthleteDetails(4, "Sunil", "Chhetri", 41, "Football");
            Console.WriteLine(athleteManagement.ViewAthleteDetails(4));



            EventManagement eventManagement = new EventManagement();
            int event1 = eventManagement.CreateEvent("Badminton Championship", "Championship", DateTime.Now.AddDays(10));
            int event2 = eventManagement.CreateEvent("Chess Tournament", "Tournament", DateTime.Now.AddDays(3));
            int event3 = eventManagement.CreateEvent("Kabaddi Match", "Match", DateTime.Now.AddDays(8));

            Console.WriteLine(eventManagement.ViewEventDetails(1));

            //event schedule changed
            eventManagement.UpdateEventDetails(2, "Fotball Leagues", "Leagues", DateTime.Now.AddDays(15));
            Console.WriteLine(eventManagement.ViewEventDetails(3));



            PerformanceTracking performanceTracking = new PerformanceTracking();
            performanceTracking.RecordAthletePerformance(athlete2, event2, "Excellent");

            performanceTracking.ViewAthletePerformance(athlete2, event2);


            //Get athletes by sport
            Console.WriteLine("\nAthlete By Sport:");
            var cricketPlayers = athleteManagement.GetAthletesBySport("Kabaddi");
            foreach (var athlete in cricketPlayers)
            {
                Console.WriteLine($"{athlete.FirstName} {athlete.LastName}");
            }

            //Get events by Type
            Console.WriteLine("\nEvent By Type:");
            var trainingEvents = eventManagement.GetEventsByType("Match");
            foreach (var e in trainingEvents)
            {
                Console.WriteLine(e);
            }

            //Get Upcoming Events
            Console.WriteLine("\nUpcoming Events:");
            var upcomingEvents = eventManagement.GetUpcomingEvents();
            foreach (var ev in upcomingEvents)
            {
                Console.WriteLine(ev);
            }

            Console.ReadLine();
        }
    }
}
        
    
