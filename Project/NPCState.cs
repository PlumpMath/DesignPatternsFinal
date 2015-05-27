using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsFinal
{
    public class NPCState : State
    {
        private static NPCState _npcState;
        private System.Windows.Forms.Form NPCForm;

        private NPCState()
        {
            NPCForm = new NPCViewForm();
            base.npcState = _npcState;
        }
        override protected void toNPC() { }

        override public System.Windows.Forms.Form StateView()
        {
            return NPCForm;
        }

        public static State initNPCState()
        {
            if (_npcState == null)
                _npcState = new NPCState();
            return _npcState;
        }
    }
}
