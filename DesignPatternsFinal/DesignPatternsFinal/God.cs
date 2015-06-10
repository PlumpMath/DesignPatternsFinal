using System;

namespace DesignPatternsFinal
{
    public abstract class God : Character
    {
        public God() : base() {}

        //protected IAbility special;
        //public abstract void specialAbility(Party team, Party enemies);

        override
        public IAbility turn(Party team, Party enemies )
        {
            ActionDecisionForm turn = new ActionDecisionForm(this);
            turn.ShowDialog();
            return turn.getDecision();
        }

        override
        public Character aim(Party enemy)
        {
            CharacterSelectForm choice = new CharacterSelectForm(enemy);
            choice.ShowDialog();
            return choice.getDecision();
        }
        override
        public Item defeat()
        {
            return null;
        }
        override
        public string ToString()
        {
            return Name;
        }
    }
}