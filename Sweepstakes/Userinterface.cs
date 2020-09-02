using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class Userinterface
    {
        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?: ");
            string userFirstName = Console.ReadLine();
            return userFirstName;
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?: ");
            string userLastName = Console.ReadLine();
            return userLastName;
        }

        public static string GetUserEmail()
        {
            Console.WriteLine("What is your Email?: ");
            string userEmail = Console.ReadLine();
            return userEmail;
        }

        public static int GetRegistrationNumber()
        {
            Console.WriteLine("What is you registration number?: ");
            int userRegistrationNumber = Int32.Parse(Console.ReadLine());
            return userRegistrationNumber;
        }

        public static string ChooseCollection()
        {
            Console.WriteLine("Would you like to use the Stack or the Queue collection? \n" +
                "Type S for slack or Type Q for queue: ");
            string collectionChoice = Console.ReadLine();
            return collectionChoice;
        }
    }
}
