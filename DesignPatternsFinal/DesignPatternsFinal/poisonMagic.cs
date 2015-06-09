using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonMagic : Item
    {
        public poisonMagic()
        {
        }
        override
        public string getname()
        {
            return "Poison Magic";
        }
        override
        public int getPoisonMax()
        {
            return 30;
        }
        override
        public int getPoisonMin()
        {
            return 10;
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
