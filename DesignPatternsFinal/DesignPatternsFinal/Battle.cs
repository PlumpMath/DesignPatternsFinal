using System;
using System.Collections.Generic;

namespace DesignPatternsFinal
{
    public class Battle
    {
        private Party home;
        private Party away;

        public Battle(ref Party home, ref Party away)
        {
            this.home = home;
            this.away = away;
        }

        public void setHome(Party home)
        {
            this.home = home;
        }

        public void setAway(Party away)
        {
            this.away = away;
        }
        public String battle()
        {
            List<int> speed = new List<int>() ;

            foreach( Character person in home )
                speed.Add(person.Dex);
            foreach (Character person in away)
                speed.Add(person.Dex);

            while (home.size() > 0 && away.size() > 0)
            {
                for (int i = 0; i < home.size(); i++)
                {
                    if (speed[i] != 0)
                        speed[i]--;
                    else
                    {
                        if (away.size() > 0)
                        {
                            IAbility action;
                            action = home.getCharacter(i).turn(home, away);
                            action.ability(away);
                            speed[i] = home.getCharacter(i).Dex;
                            killed(speed);
                        }
                    }
                }

                for (int i = 0; i < away.size(); i++)
                {
                    int ix = i + home.size();
                    if (speed[ix] != 0)
                        speed[ix]--;
                    else
                    {
                        if (home.size() > 0)
                        {
                            away.getCharacter(i).turn(away, home);
                            speed[ix] = home.getCharacter(i).Dex;
                            killed(speed);
                        }
                    }
                }
            }
            String response = ("The battle is over.\n");
            if (home.size() == 0)
                return response + ("You lost...");
            else
                return response + ("You won!");
        }

        private string killed( List<int> speed )
        {
            string response = "";
            for( int i = 0 ; i < speed.Count ; i++)
            {
                if( i < home.size() )
                {
                    Character test = home.getCharacter(i);
                    if( test.HP <= 0 )
                    {
                        response += test.Name + " has been killed.\n";
                        speed.RemoveAt(i);
                        home.removeCharacter(i);
                        i--;
                    }
                }
                else
                {
                    int awayIx = i - home.size();
                    Character test = away.getCharacter(awayIx);
                    if (test.HP <= 0)
                    {
                        response += test.Name + " has been killed.\n";
                        speed.RemoveAt(i);
                        away.removeCharacter(awayIx);
                        i--;
                    }
                }
            }
            return response;
        }
    }
}