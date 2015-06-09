using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Javelin: Item
    {
        public Javelin()
        {
        }

        public string getName()
        {
            return "Javelin";
        }
        public int getDamageMax()
        {
            return 30;
        }
        public int getDamageMin()
        {
            return 1;
        }
    }
}
