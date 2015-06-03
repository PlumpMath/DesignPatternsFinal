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
            theWorld = this;
            heroParty = heros;
            theDungeon = new Dungeon(theWorld);
            theDungeon.generateDungeon();
            //theWorld = this;
        }

        public static World init(ref Party heros)
        {
            theWorld = new World(heros);
            theWorld.currentState = State.initState(theWorld);
            return theWorld;
        }
        public void init()
        {
            PrimaryViewForm mainView = new PrimaryViewForm(this);
            mainView.Show();
            this.currentState.StateView().Show();
        }
    }
}
