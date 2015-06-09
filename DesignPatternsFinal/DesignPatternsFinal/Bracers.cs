using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Bracers : Item
    {
        public Bracers()
        {
        }
        override
        public string getname()
        {
            return "Bracers";
        }
        override
        public int getBlockMax()
        {
            return 25;
        }
        override
        public int getBlockMin()
        {
            return 15;
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
