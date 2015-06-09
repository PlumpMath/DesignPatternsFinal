using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Staff : Item
    {
        public Staff()
        {
        }

        public string getName()
        {
            return "Staff";
        }
        public int getDamageMax()
        {
            return 20;
        }
        public int getDamageMin()
        {
            return 5;
        }
    }
}
