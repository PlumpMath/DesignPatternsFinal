using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class BowNArrow : Item
    {
        public BowNArrow()
        {
        }
        override
        public string getname()
        {
            return "Bow and Arrow";
        }
        override
        public int getDamageMax()
        {
            return 25;
        }
        override
        public int getDamageMin()
        {
            return 10;
        }
        override
       public int getHealMax()
        {
            return 0;
        }
        override
        public int getHealMin()
        {
            return 0;
        }
        override
        public int getPoisonMax()
        {
            return 0;
        }
        override
        public int getPoisonMin()
        {
            return 0;
        }
        override
        public int getBlockMax()
        {
            return 0;
        }
        override
        public int getBlockMin()
        {
            return 0;
        }
        

    }
}
