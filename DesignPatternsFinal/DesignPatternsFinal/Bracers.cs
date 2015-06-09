using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Bracers : Item
    {
        public Bracers()
        {
        }

        public string getName()
        {
            return "Bracers";
        }
        public int getBlockMax()
        {
            return 25;
        }
        public int getBlockMin()
        {
            return 15;
        }
    }
}
