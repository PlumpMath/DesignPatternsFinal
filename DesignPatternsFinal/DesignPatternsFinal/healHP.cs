using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healHP : Item
    {
        public healHP()
        {
        }
        override
        public string getname()
        {
            return "Heal Health";
        }
        override
        public int getHealMax()
        {
            return 40;
        }
        override
        public int getHealMin()
        {
            return 20;
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
