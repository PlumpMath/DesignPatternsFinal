using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemsProject
{
    public abstract class item
    {
        public abstract string getname();
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
