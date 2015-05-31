using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class BattleState : State
    {
        private World theWorld;
        private static BattleState _battleState;
        private System.Windows.Forms.Form BattleForm;

        private BattleState(ref World world)
        {
            theWorld = world;
            BattleForm = new BattleViewForm();
            base.battleState = _battleState;
        }
        public static BattleState initBattleState(ref World world)
        {
            if(_battleState == null)
                _battleState = new BattleState(ref world);
            return _battleState;
        }

        override protected void toBattle(){ }
        override public System.Windows.Forms.Form StateView()
        {
            return BattleForm;
        }
    }
}
