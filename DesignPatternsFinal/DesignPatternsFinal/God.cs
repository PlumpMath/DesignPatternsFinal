using System;

namespace DesignPatternsFinal
{
    public abstract class God : Character
    {
        protected IAbility special;

        public abstract void specialAbility(Party team, Party enemies);

        override
        public IAbility turn( ref Party team, ref Party enemies )
        {
            ActionDecisionForm turn = new ActionDecisionForm(this);
            turn.ShowDialog();
            return turn.getDecision();
        }

        override
        public Character aim(ref Party enemy)
        {
            CharacterSelectForm choice = new CharacterSelectForm(enemy);
            choice.ShowDialog();
            return choice.getDecision();
        }
        override
        public string ToString()
        {
            return Name;
        }
    }
}