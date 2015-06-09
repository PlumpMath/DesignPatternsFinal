using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Curiass : Item
    {
        public Curiass()
        {
        }

        public string getName()
        {
            return "Curiass";
        }
        public int getBlockMax()
        {
            return 40;
        }
        public int getBlockMin()
        {
            return 20;
        }
    }
}
