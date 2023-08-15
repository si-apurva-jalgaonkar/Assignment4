using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzManagement
{
    internal class AthleteManagement
    {
        List<Athlete> athletes = new List<Athlete>();
        public int nextAthleteId = 1;
        public int RegisterAthlete(string firstName, string lastName, int age, string sport, DateTime dateTime)
        {
            int athleteId = nextAthleteId++;


            Athlete athlete = new Athlete(firstName, lastName, age, sport, dateTime);

            athletes.Add(athlete);
            Console.WriteLine("Athlete added successfully!");
            return athlete.AthleteId;


        }
        public string ViewAthleteDetails(int athleteId)
        {
            Athlete athlete = athletes.FirstOrDefault(a => a.AthleteId == athleteId);
            if (athlete != null)
            {
                return $"Name: {athlete.FirstName} {athlete.LastName}\nAge: {athlete.Age}\nSport: {athlete.Sport}\nRegistration Date: {athlete.RegistrationDate}";
            }
            else
            {
                return "Athlete not found";
            }
        }

        public string UpdateAthleteDetails(int athleteId, string firstName, string lastName, int age, string sport)
        {
            Athlete athlete = athletes.FirstOrDefault(a => a.AthleteId == athleteId);
            if (athlete != null)
            {
                athlete.FirstName = firstName;
                athlete.LastName = lastName;
                athlete.Age = age;
                athlete.Sport = sport;
                return "Sucessfully updated.";
            }
            else
            {
                return "Athlete not found";
            }
        }

        public string RemoveAthlete(int athleteId)
        {
            Athlete athlete = athletes.FirstOrDefault(a => a.AthleteId == athleteId);
            if (athlete != null)
            {
                athletes.Remove(athlete);
                return "Athlete removed sucessfully";
            }
            else
            {
                return "Athlete not found";
            }
        }


        public List<Athlete> GetAthletesBySport(string sport)
        {
            return athletes.Where(a => a.Sport == sport).ToList();
        }
    }
}
