using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class ThrowingKnife : Item
    {
        public ThrowingKnife()
        {}

        override
        public string getname()
        {
            return "Throwing Knife";
        }
        override
        public int getDamageMax()
        {
            return 10;
        }
        override
        public int getDamageMin()
        {
            return 6;
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
    }
}
