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
        private Dungeon theDungeon;
        private State currentState;
        private Party heroParty;
        private Party monsterParty;
        private static World theWorld;

        private World(Party heros)
        {
            heroParty = heros;
            theDungeon = new Dungeon();
            theDungeon.generateDungeon();
            theWorld = this;
        }

        public static World init(Party heros)
        {
            theWorld = new World(heros);
            theWorld.currentState = State.initState();
            return theWorld;
        }
        public void init()
        {
            this.currentState.StateView().Show();
        }
    }
}
