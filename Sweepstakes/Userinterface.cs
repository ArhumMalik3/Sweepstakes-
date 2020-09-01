using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class Userinterface
    {
        public static void GetFirstName()
        {
            Console.WriteLine("What is your first name?: ");
            string userFirstName = Console.ReadLine();
        }

        public static void GetLastName()
        {
            Console.WriteLine("What is your last name?: ");
            string userLastName = Console.ReadLine();
        }

        public static void GetUserEmail()
        {
            Console.WriteLine("What is your Email?: ");
            string userEmail = Console.ReadLine();
        }

        public static void GetRegistrationNumber()
        {
            Console.WriteLine("What is you registration number?: ");
            string userRegistrationNumber = Console.ReadLine();
        }
    }
}
