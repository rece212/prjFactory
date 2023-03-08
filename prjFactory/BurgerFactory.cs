using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFactory
{
    public class BurgerFactory
    {
        public IBurger returnInstance;
        public IBurger getBurger(String BurgerType)
        {
            if(BurgerType.ToLower().Equals("chicken"))
            {
                returnInstance = new ChickenBurger();
            }
            else if (BurgerType.ToLower().Equals("Cheese"))
            {
                returnInstance = new CheeseBurger();
            }
            else
            {
                returnInstance = new PlainBurger();
            }
            return returnInstance;
        }
    }
}
