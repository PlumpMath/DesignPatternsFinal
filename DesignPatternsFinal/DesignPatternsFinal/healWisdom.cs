using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healWisdom : Item
    {
        public healWisdom()
        {
        }
        override
        public string getname()
        {
            return "Heal Wisdom";
        }
        override
        public int getHealMax()
        {
            return 15;
        }
        override
        public int getHealMin()
        {
            return 10;
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
