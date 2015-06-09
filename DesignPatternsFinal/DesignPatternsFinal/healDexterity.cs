using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healDexterity : Item
    {
        public healDexterity()
        {
        }
        override
        public string getname()
        {
            return "Heal Dexterity";
        }
        override
        public int getHealMax()
        {
            return 10;
        }
        override
        public int getHealMin()
        {
            return 2;
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
    }
}
