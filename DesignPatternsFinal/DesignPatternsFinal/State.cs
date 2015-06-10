using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternsFinal
{
    public abstract class State
    {
        private static World theWorld;
        private static State _currentState;
        protected static State currentState { set { _currentState = value; } get { return _currentState; } }
        private static State _battleState;
        protected static State battleState { set { _battleState = value; } get { return _battleState; } }
        private static State _navigationState;
        protected static State navigationState { set { _navigationState = value; } get { return _navigationState; } }
        private static State _inventoryState;
        protected static State inventoryState { set { _inventoryState = value; } get { return _inventoryState; } }
        private static State _npcState;
        protected static State npcState { set { _npcState = value; } get { return _npcState; } }

        private static System.Windows.Forms.Form currentForm;

        protected State(World world)
        {
            theWorld = world;
            battleState = new BattleState();
            //navigationState = NavigationState.initNavigationState();
            inventoryState = new InventoryState();
            npcState = new NPCState();
        }
        protected State()
        {
        }

        public static void toBattle(Event e)
        {
            currentForm.Hide();
            currentState = battleState;
            currentForm = currentState.StateView();
            //((BattleViewForm)currentForm).newBattle((BattleEvent)e);
            currentForm.Show();
            ((BattleViewForm)currentForm).newBattle((BattleEvent)e);
        }
        public static void toInventory()
        {
            currentForm.Hide();
            currentState = inventoryState;
            currentForm = currentState.StateView();
            currentForm.Show();
        }
        public static void toNavigate(Event e = null)
        {
            currentForm.Hide();
            currentState = navigationState;
            currentForm = currentState.StateView();
            currentForm.Show();
        }
        public static void toNPC(Event e)
        {
            currentForm.Hide();
            currentState = npcState;
            currentForm = currentState.StateView();
            currentForm.Show();
        }

        abstract public Form StateView();
        //abstract public void HandleEvent();

        public static State initState(World d)
        {
            _currentState = NavigationState.initNavigationState(d);
            currentForm = _currentState.StateView();
            return _currentState;
        }
        public static Form currentStateView()
        {
            return currentForm;
        }
    }
}
