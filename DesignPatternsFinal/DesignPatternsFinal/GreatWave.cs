using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class GreatWave : IAbility
    {
        public String getName()
        {
            return "Great Wave";
        }
        public String ability(Party party)
        {
            String response = "";

            response += "Poseidon sends out a great wave!";
            //Console.WriteLine("Poseidon sends out a great wave!");

            foreach (Character enemy in party)
            {
                int oldHP = enemy.HP;
                double damage = (30 - enemy.Con) * enemy.Stance;
                double newHP = oldHP - damage;
                enemy.HP = ((int)newHP);

                response += enemy.Name + " was hit by the great wave.\n";
                response += enemy.Name + " lost " + enemy.Str + " HP and now has\n";
                response += enemy.HP + " left.\n";
                //Console.WriteLine(enemy.getName() + " was hit by the great wave.");
                //Console.WriteLine(enemy.getName() + " lost " + enemy.getStength() + " HP and now has "
                //                  + enemy.getHp() + " left.");
            }
            return response;
        }
    }
}
