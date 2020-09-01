using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation

    {
        public Sweepstakes sweepstakes;

        public Simulation()
        {
            sweepstakes = new Sweepstakes("car");
            Stack
        }
        
        public void CreateMarketingFirmWithManager()
        {

        }

        public void Testing()
        {
            string firstName = Userinterface.GetFirstName();
            string lastName = Userinterface.GetLastName();
            string email = Userinterface.GetUserEmail();
            int registrationNumber = Userinterface.GetRegistrationNumber();
            Contestant contestant = new Contestant(firstName, lastName, email, registrationNumber);
            sweepstakes.RegisterContestant(contestant);
            

        }
    }
}
