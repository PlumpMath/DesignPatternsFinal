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
        }

        public string getName()
        {
            return "Helmet";
        }
        public int getBlockMax()
        {
            return 30;
        }
        public int getBlockMin()
        {
            return 25;
        }
    }
}
