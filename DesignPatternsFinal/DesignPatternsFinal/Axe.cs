using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Axe : Item
    {
        public Axe()
        {}
        override
        public string getname()
        {
            return "Axe";
        }
        override
        public int getDamageMax()
        {
            return 20;
        }
        override
        public int getDamageMin()
        {
            return 5;
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
