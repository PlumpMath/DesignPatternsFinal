using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Helmet : Item
    {
        public Helmet()
        {
            name = "Helmet";
            blockMax = 30;
            blockMin = 25;
        }

        public abstract string getName();
        public abstract int getBlockMax();
        public abstract int getBlockMin();
    }
}
