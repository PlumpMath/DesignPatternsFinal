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
        }
        public void onTrigger(int roomNum)
        {
			Random rand = new Random ();
			double selection = rand.NextDouble ();
			if (selection > .67) 
			{
				a = RandomEnemyGenerator.getEnemies (roomNum);
				if (!a.isEmpty ()) 
				{
					b = new Battle(ref h, ref a);
					State.toBattle (this);
				}
			}
        }
        public Party getFoes()
        {
            return a;
        }
        public Battle theFight()
        {
            return b;
        }
    }
}
