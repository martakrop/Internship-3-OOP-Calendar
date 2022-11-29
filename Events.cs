using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendar
{
    public class Events
    {

        public int Id;
        public string Name;
        public string Location;
        public DateTime StartDate;
        public DateTime EndDate;
        public List<string> Emails;



        public Events(int aId, string aName, string aLocation, DateTime aStartDate, DateTime aEndDate, List<string> aEmails)
        {
            Id = aId;
            Name = aName;
            Location = aLocation;
            StartDate = aStartDate;
            EndDate = aEndDate;
            Emails = aEmails;
        }





    }






}