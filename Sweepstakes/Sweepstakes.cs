using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Random rand = new Random();
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();

        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            int dictionaryCount = contestants.Count + 1;
            contestants.Add(dictionaryCount, contestant); 
        }

        public Contestant PickWinner()
        {
            
            return contestants[rand.Next()];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Name: {contestant.firstName} {contestant.lastName}) \n" +
                $"Email: {contestant.eMail}\n" +
                $"Registration Number: {contestant.registrationNumber}");
        }
    }
}
