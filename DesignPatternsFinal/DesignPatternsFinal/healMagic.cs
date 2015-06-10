using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healMagic : Item
    {
        public healMagic()
        {
        }
        override
        public string getname()
        {
            return "Heal Magic";
        }
        override
        public int getHealMax()
        {
            return 25;
        }
        override
        public int getHealMin()
        {
            return 5;
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
