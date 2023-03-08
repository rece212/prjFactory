using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFactory
{
    public class CheeseBurger : IBurger
    {
        public string getBun()
        {
            return "Plain";
        }

        public string getCondiments()
        {
            return "Cheese";
        }

        public string getPatty()
        {
            return "Not beef";
        }
    }
}
