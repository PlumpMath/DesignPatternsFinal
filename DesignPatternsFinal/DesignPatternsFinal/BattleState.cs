using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class BattleState : State
    {
        private static BattleState _battleState;
        private static System.Windows.Forms.Form BattleForm;

        public BattleState()
        {
            if ((_battleState==null))
            {
                BattleForm = new BattleViewForm();
                _battleState = this;
                battleState = _battleState;
            }
        }

        new public void toBattle(){ }
        override public System.Windows.Forms.Form StateView()
        {
            return BattleForm;
        }
    }
}
