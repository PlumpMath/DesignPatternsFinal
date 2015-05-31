using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    [Serializable()]
    public class World
    {
        public Dungeon theDungeon;
        public State currentState;
        public Party heroParty;
        public Party monsterParty;
        private static World theWorld;

        private World(Party heros)
        {
            heroParty = heros;
            theDungeon = new Dungeon();
            theDungeon.generateDungeon();
            theWorld = this;
        }

        public static World init(ref Party heros)
        {
            theWorld = new World(heros);
            theWorld.currentState = State.initState(ref theWorld);
            return theWorld;
        }
        public void init()
        {
            this.currentState.StateView().Show();
        }
    }
}
