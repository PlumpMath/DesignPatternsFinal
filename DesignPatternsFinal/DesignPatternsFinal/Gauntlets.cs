using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Gauntlets : Item
    {
        public Gauntlets()
        {
        }
        override
        public string getname()
        {
            return "Gauntlets";
        }
        override
        public int getBlockMax()
        {
            return 20;
        }
        override
        public int getBlockMin()
        {
            return 4;
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
    }
}
