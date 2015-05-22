using System;
using System.Collections.Generic;

namespace DesignPatternsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> h = new List<Character>();
            for (int i = 0; i < 3; i++)
                h.Add(new Poseidon());
            List<Character> a = new List<Character>();
            for (int i = 0; i < 2; i++)
                a.Add(new Beast());

            Party home = new Party(h);
            Party away = new Party(a);

            Battle battlefield = new Battle(home, away);
            battlefield.battle();
        }
    }
}
