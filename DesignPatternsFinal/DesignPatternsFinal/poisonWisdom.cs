using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonWisdom : Item
    {
        public poisonWisdom()
        {
        }
        override
        public string getname()
        {
            return "Poison Wisdom";
        }
        override
        public int getPoisonMax()
        {
            return 14;
        }
        override
        public int getPoisonMin()
        {
            return 7;
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
        override
        public int getDamageMax()
        {
            return 0;
        }
        override
        public int getDamageMin()
        {
            return 0;
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
    }
}
