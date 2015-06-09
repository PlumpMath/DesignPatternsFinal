using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Mace : Item
    {
        public Mace()
        {
        }

        public string getName()
        {
            return "Mace";
        }
        public int getDamageMax()
        {
            return 10;
        }
        public int getDamageMin()
        {
            return 5;
        }
    }
}
