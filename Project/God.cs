using System;

namespace DesignPatternsProject
{
    public abstract class God : Character
    {
        //private Ability special;

        public abstract void specialAbility(Party team, Party enemies);

        override
        public void turn( Party team, Party enemies )
        {
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
            }
        }

        override
        public Character aim( Party enemy )
        {
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

        }

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
        }

        override
        public string ToString()
        {
            return getName();
        }
    }
}