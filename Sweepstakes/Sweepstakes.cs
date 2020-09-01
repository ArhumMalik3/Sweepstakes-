using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public Sweepstakes(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            int dictionaryCount = contestants.Count + 1;
            contestants.Add(dictionaryCount, contestant); 
        }

        public Contestant PickWinner()
        {
            return null;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
