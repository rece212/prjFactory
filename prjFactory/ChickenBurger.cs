using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFactory
{
    public class ChickenBurger : IBurger
    {
        public string getBun()
        {
            return "French Bread";
        }

        public string getCondiments()
        {
            return "mayo";
        }

        public string getPatty()
        {
            return "Chicken";
        }
    }
}
