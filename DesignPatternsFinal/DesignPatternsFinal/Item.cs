using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public abstract class Item
    {
        public abstract string getName();
        public abstract int getDamageMax();
        public abstract int getDamageMin();
        public abstract int getHealMax();
        public abstract int getHealMin();
        public abstract int getPoisonMax();
        public abstract int getPoisonMin();
        public abstract int getBlockMax();
        public abstract int getBlockMin();
    }
}
