using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsFinal
{
    class BattleEvent : Event
    {
        Battle b;
        Party p;
        public BattleEvent(ref Party mon)
        {
            p = mon;
        }
        public override void onTrigger()
        {
            b = new Battle(ref p, ref p);
            b.battle();
        }
    }
}
