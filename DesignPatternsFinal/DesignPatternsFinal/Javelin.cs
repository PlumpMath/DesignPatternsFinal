using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Javelin: Item
    {
        public Javelin()
        {
        }
        override
        public string getname()
        {
            return "Javelin";
        }
        override
        public int getDamageMax()
        {
            return 30;
        }
        override
        public int getDamageMin()
        {
            return 1;
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
