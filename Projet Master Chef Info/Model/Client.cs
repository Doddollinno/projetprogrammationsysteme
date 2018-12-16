using Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class StrategyClientnbr : Strategy
    {
        public override void Behavior()
        {
            
        }
        public int RandomNumber(int nbrmin, int nbrmax)
        {
            nbrmin = 1;
            nbrmax = 10;
            Random random = new Random();
            return random.Next(nbrmin, nbrmax);
        }

        class intervalle
        {
            
            
        }

        
    }

}
    