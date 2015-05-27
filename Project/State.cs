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
        private static State _currentState;
        protected State currentState { set { _currentState = value; } get { return _currentState; } }
        private static State _battleState;
        protected State battleState { set { _battleState = value; } get { return _battleState; } }
        private static State _navigationState;
        protected State navigationState { set { _navigationState = value; } get { return _navigationState; } }
        private static State _inventoryState;
        protected State inventoryState { set { _inventoryState = value; } get { return _inventoryState; } }
        private static State _npcState;
        protected State npcState { set { _npcState = value; } get { return _npcState; } }

        private static System.Windows.Forms.Form currentForm;

        public State()
        {
            //battleState = BattleState.initBattleState();
            //navigationState = NavigationState.initNavigationState();
            //inventoryState = InventoryState.initInventoryState();
            //npcState = NPCState.initNPCState();
        }

        virtual protected void toBattle()
        {
            currentForm.Hide();
            currentState = battleState;
            currentForm = currentState.StateView();
            currentForm.Show();
        }
        virtual protected void toInventory()
        {
            currentForm.Hide();
            currentState = inventoryState;
            currentForm = currentState.StateView();
            currentForm.Show();
        }
        virtual protected void toNavigate()
        {
            currentForm.Hide();
            currentState = navigationState;
            currentForm = currentState.StateView();
            currentForm.Show();
        }
        virtual protected void toNPC()
        {
            currentForm.Hide();
            currentState = npcState;
            currentForm = currentState.StateView();
            currentForm.Show();
        }

        abstract public Form StateView();
        abstract public void HandleEvent();

        public static State initState()
        {
            _currentState = NavigationState.initNavigationState();
            return _currentState;
        }
    }
}
