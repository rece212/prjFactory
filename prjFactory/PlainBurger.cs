using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFactory
{
    public class PlainBurger : IBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "tomato sauce";
        }

        public string getPatty()
        {
            return "Beef";
        }
    }
}
