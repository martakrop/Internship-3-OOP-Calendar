using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendar
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public Dictionary<int, bool> Presence;


        public Person(string aFirstName, string aLastName, string aEmail, Dictionary<int, bool> aPresence)
        {
            FirstName = aFirstName;
            LastName = aLastName;
            Email = aEmail;
            Presence = aPresence;
        }
    }
}
