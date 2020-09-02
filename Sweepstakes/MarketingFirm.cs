using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;
        //Over here I was able to pass ISweepstakesManager into the constructor and pass in whichever collection the user chooses
        //It makes the code alot more flexible 
        //Now if I need to add or change code it wont take nearly as long because I can either add another interface or only have to change it at one spot
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        public void CreateSweepstakes()
        {
            string collection = Userinterface.ChooseCollection();
            if (collection == "S" || collection == "s")
            {
                _manager = new SweepstakesStackManager(); 
            }
            else if (collection == "Q" || collection == "q")
            {
                _manager = new SweepstakesQueueManager();
            }
        }
    }
}
