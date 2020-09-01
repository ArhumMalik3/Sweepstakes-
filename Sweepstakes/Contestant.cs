using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string eMail;
        public int registrationNumber;

        public Contestant(string firstName, string lastName, string eMail, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eMail = eMail;
            this.registrationNumber = registrationNumber;
        }

    }
}
