using System;
using System.Collections.Generic;

namespace DesignPatternsFinal
{
    public class Battle
    {
        private Party home;
        private Party away;

        public Battle(Party home, Party away)
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
        public string battle()
        {
            List<int> speed = new List<int>() ;

            foreach( Character person in home )
                speed.Add( person.getSpeed() );
            foreach (Character person in away)
                speed.Add( person.getSpeed() );

            while( home.size() > 0 && away.size() > 0 )
            {
                for (int i = 0; i < home.size(); i++ )
                {
                    if (speed[i] != 0)
                        speed[i]--;
                    else
                    {
                        if (away.size() > 0)
                        {
                            home.getCharacter(i).turn(home, away);
                            speed[i] = home.getCharacter(i).getSpeed();
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
                            speed[ix] = home.getCharacter(i).getSpeed();
                            killed(speed);

                        }
                    }
                }
            }
            //Console.Write("The battle is over.");
            string response = ("The battle is over.\n");
            if (home.size() == 0)
                return response + ("You lost...");
                //Console.WriteLine("You lost...");
            else
                return response + ("You won!");
                //Console.WriteLine("You won!");
            
        }

        private string killed( List<int> speed )
        {
            string response = "";
            for( int i = 0 ; i < speed.Count ; i++)
            {
                if( i < home.size() )
                {
                    Character test = home.getCharacter(i);
                    if( test.getHp() <= 0 )
                    {
                        response += test.getName() + " has been killed.\n";
                        //Console.WriteLine(test.getName() + " has been killed.");
                        speed.RemoveAt(i);
                        home.removeCharacter(i);
                        i--;
                    }
                }
                else
                {
                    int awayIx = i - home.size();
                    Character test = away.getCharacter(awayIx);
                    if (test.getHp() <= 0)
                    {
                        response += test.getName() + " has been killed.\n";
                        //Console.WriteLine(test.getName() + " has been killed.");
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