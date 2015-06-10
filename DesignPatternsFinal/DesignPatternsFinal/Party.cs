using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsFinal
{

    public class Party : IEnumerable<Character>
    {
        private List<Character> party;
        private Inventory inv;

        public Party()
        {
            party = new List<Character>();
            inv = new Inventory();
            inv.add(new Helmet());
            inv.add(new Curiass());
            inv.add(new LongSword());
            inv.add(new healHP());
            inv.add(new poisonHP());
            inv.add(new BowNArrow());
        }

        public Party( List<Character> party, Inventory inventory )
        {
            this.party = party;
            this.inv = inventory;
        }

        public Inventory getInventory()
        {
            return inv;
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
		public bool isEmpty()
		{
			if (size () == 0)
				return true;
			else
				return false;
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