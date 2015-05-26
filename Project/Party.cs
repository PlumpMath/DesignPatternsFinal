using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsProject
{

    public class Party : IEnumerable<Character>
    {
        private List<Character> party;
        private Room location;

        public Party()
        {
            party = new List<Character>();
            location = null;
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
            //Console.WriteLine( "No character at this location." );
            throw new IndexOutOfRangeException("No character at this location.");
        }

        public void removeCharacter( int index )
        {
            if (index < this.size() && index >= 0)
                party.RemoveAt(index);
            else
            {
                //Console.WriteLine("No character at this location.");
                throw new IndexOutOfRangeException("No character at this location.");
            }
        }

        public void setLocation( Room goTo )
        {
            location = goTo;
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