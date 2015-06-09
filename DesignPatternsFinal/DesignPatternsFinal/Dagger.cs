using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Dagger : Item
    {
        public Dagger()
        {
        }
        public string getName()
        {
            return "Dagger";
        }
        public int getDamageMax()
        {
            return 5;
        }
        public int getDamageMin()
        {
            return 1;
        }
    }
}
