using System;

namespace DesignPatternsFinal
{
    public abstract class God : Character
    {
        protected IAbility special;

        public abstract void specialAbility(Party team, Party enemies);

        override
        public String turn( ref Party team, ref Party enemies )
        {
            ActionDecisionForm turn = new ActionDecisionForm(this);
            turn.ShowDialog();
            return turn.getDecision().getName();
            /*
            if (this.getHp() > 0)
            {
                Console.WriteLine("It is " + getName() + "'s turn to move.");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");
                Console.WriteLine("3. Special");
                Console.Write("Enter: ");
                int choice = getInput(3);

                if (choice == 3)
                    specialAbility(team, enemies);
                else if (choice == 2)
                    defend();
                else
                    attack(enemies);
            }*/
        }

        override
        public Character aim(ref Party enemy)
        {
            CharacterSelectForm choice = new CharacterSelectForm(enemy);
            choice.ShowDialog();
            return choice.getDecision();
        }
            /*
            Console.WriteLine("Who should " + getName() + " attack?");

            int cnt = 1 ;
            foreach( Character foe in enemy )
            {
                Console.WriteLine(cnt + ". " + foe);
                cnt++;
            }
            Console.WriteLine("Enter: ");

            int choice = getInput(cnt - 1);
            return enemy.getCharacter(choice);

        }*/
        /*
        private static int getInput( int choices )
        {
            while (true)
            {
                string kb = Console.ReadLine();
                for (int i = 1; i <= choices; i++)
                {
                    if (kb.Trim().Equals(i.ToString()))
                        return i -1 ;
                }

                Console.WriteLine("Proper input wasn't entered. Try Again.");
                Console.Write("Enter: ");
            }
        }*/

        override
        public string ToString()
        {
            //return getName(); 
            return Name;
        }
        /*Object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }*/
    }
}