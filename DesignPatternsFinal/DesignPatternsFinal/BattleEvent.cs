using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsFinal
{
    public class BattleEvent : Event
    {
        private Battle b;
        private Party h;
        private Party a;
        public BattleEvent(Party her, Party mon)
        {
            h = her;
            a = mon;
            b = new Battle(ref h, ref a);
        }
        public void onTrigger()
        {
            State.toBattle(this);
        }
        public Party getFoes()
        {
            return a;
        }
        public Battle startFight()
        {
            return b;
        }
    }
}
