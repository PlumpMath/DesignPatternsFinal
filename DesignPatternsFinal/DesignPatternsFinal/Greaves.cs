using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Greaves : Item
    {
        public Greaves()
        {
        }

        public string getName()
        {
            return "Greaves";
        }
        public int getBlockMax()
        {
            return 40;
        }
        public int getBlockMin()
        {
            return 30;
        }
    }
}
