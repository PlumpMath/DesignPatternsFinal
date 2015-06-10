using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonConstitution : Item
    {
        public poisonConstitution()
        { }
        override
         public string getname()
        {
            return "Poison Constitution";
        }
        override
        public int getPoisonMax()
        {
            return 12;
        }
        override
        public int getPoisonMin()
        {
            return 6;
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
