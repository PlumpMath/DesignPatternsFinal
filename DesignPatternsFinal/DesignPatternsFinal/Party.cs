using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsFinal
{

    public class Party : IEnumerable<Character>
    {
        private List<Character> party;

        public Party()
        {
            party = new List<Character>();
        }

        public Party( List<Character> party )
        {
            this.party = party;
        }

        public void addCharacter( Character character )
        {
           if (character != null)
                party.Add(character);
        }

        public Character getCharacter( int index )
        {
            if (index < this.size() && index >= 0)
                return party[index] ;
            throw new IndexOutOfRangeException("No character at this location.");
        }

        public void removeCharacter( int index )
        {
            if (index < this.size() && index >= 0)
                party.RemoveAt(index);
            else
            {
                throw new IndexOutOfRangeException("No character at this location.");
            }
        }

        public int size()
        {
            return party.Count;
        }

        IEnumerator<Character> IEnumerable<Character>.GetEnumerator()
        {
            return party.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return party.GetEnumerator();
        }
    }
}