using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzManagement
{
    internal class Athlete
    {

        private static int nextAthletId = 1;
        public int AthleteId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Athlete() { }
        public Athlete(string firstName, string lastName, int age, string sport, DateTime regdate)
        {
            AthleteId = nextAthletId++;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sport = sport;
            RegistrationDate = regdate;
        }
    }
}

    

