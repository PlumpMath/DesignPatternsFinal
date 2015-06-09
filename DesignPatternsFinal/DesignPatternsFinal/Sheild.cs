using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Sheild : Item
    {
        public Sheild()
        {
        }

        public abstract string getName()
        {
            return "Sheild";
        }
        public abstract int getBlockMax()
        {
            return 75;
        }
        public abstract int getBlockMin()
        {
            return 20;
        }
    }
}
