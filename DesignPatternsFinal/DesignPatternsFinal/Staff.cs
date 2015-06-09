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
            name = "Staff";
            damageMax = 20;
            damageMin = 5;
        }
    }
}
