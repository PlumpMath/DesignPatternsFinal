using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsFinal
{
    public class NPCState : State
    {
        private static NPCState _npcState;
        private static System.Windows.Forms.Form NPCForm;

        public NPCState()
        {
            if ((_npcState == null))
            {
                NPCForm = new NPCViewForm();
                _npcState = this;
                npcState = _npcState;
            }
        }
        new public void toNPC() { }

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
