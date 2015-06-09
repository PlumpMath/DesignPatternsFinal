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
            name = " Greaves";
            blockMax = 40;
            blockMin = 30;
        }

        public abstract string getName();
        public abstract int getBlockMax();
        public abstract int getBlockMin();
    }
}
