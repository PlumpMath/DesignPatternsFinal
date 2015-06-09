using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Gauntlets : Item
    {
        public Gauntlets()
        {
        }

        public string getName()
        {
            return "Gauntlets";
        }
        public int getBlockMax()
        {
            return 20;
        }
        public int getBlockMin()
        {
            return 4;
        }
    }
}
