using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioSite.Models
{
    public class Data
    {
        public MyInfo GetMyInfo()
        {
            return new MyInfo()
            {
                FirstName = "Henrik",
                LastName = "Bochesa",
                MiddleName = "Levin",
                Email = "Bochesa@gmail.com",
                PhoneNumber = "+45 61 26 64 02",
                Title = "Junior Developer"
            };
        }
        public ContactMe GetContactMe()
        {
            return new ContactMe()
            { Feedback = "" };
        }
        public IEnumerable<Portfolio> GetPortfolios()
        {
            return new List<Portfolio>
            {
               // new Portfolio{ Id=1, Link="https://github.com/bochesa/ScoreBoard", Name="ScoreBoard", Description="beskrivelse", Picture="/images/pic01.jpg"},
                // new Portfolio{ Id=2, Link="https://github.com/bochesa/PumpDashboard", Name="Pump Dashboard", Description="beskrivelse2", Picture="/images/Work_01.jpg"},
                new Portfolio{ Id=3, Link="https://github.com/bochesa/CykelKlubben", Name="Cykelklubben", Description="beskrivelse3", Picture="/images/Work_02.png"},
                //new Portfolio{ Id=4, Link="", Name="Test4", Description="beskrivelse4", Picture="/images/Work_04.jpg"},
                //new Portfolio{ Id=5, Link="", Name="Test5", Description="beskrivelse5", Picture="/images/Work_05.jpg"},
                //new Portfolio{ Id=6, Link="", Name="Test6", Description="beskrivelse6", Picture="/images/Work_06.jpg"},
                //new Portfolio{ Id=7, Link="", Name="Test7", Description="beskrivelse7", Picture="/images/Work_07.jpg"},
                //new Portfolio{ Id=8, Link="", Name="Test8", Description="beskrivelse8", Picture="/images/Work_08.jpg"}

            };
        }
    }
}
