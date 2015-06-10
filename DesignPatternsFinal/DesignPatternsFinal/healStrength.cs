using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healStrength : Item
    {
        public healStrength()
        {
        }
        override
        public string getname()
        {
            return "Heal Strength";
        }
        override
        public int getHealMax()
        {
            return 20;
        }
        override
        public int getHealMin()
        {
            return 15;
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
