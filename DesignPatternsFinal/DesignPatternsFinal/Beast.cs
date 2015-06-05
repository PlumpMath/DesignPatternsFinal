using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    abstract class Beast : Character
    {
        public Beast()
        {

        }

        override
        public IAbility turn(Party team, Party enemies)
        {
            Random rand = new Random();
            double choice = rand.NextDouble();
            if (choice > .75)
                return this.moves[(int)MOVES.DEFEND];
            else
                return this.moves[(int)MOVES.ATTACK];
        }

        override
        public Character aim(Party enemy)
        {
            Random rand = new Random();
            int choice = rand.Next(enemy.size());
            return enemy.getCharacter(choice);
        }
    }
}
