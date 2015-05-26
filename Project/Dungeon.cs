using System;
using System.Collections.Generic;

namespace Project
{
	public class Dungeon : LinkedList<Room>
	{
		LinkedList<Room>[] dungeon;
		Room mid;
		Room start;
        Room end;

		public Dungeon()
		{
			this.dungeon = new LinkedList<Room>[55];
			for (int i=0; i < dungeon.Length ; i++) 
			{
				dungeon [i] = new LinkedList<Room> ();
			}
		}

        public Room getMid()
        {
            return this.mid;
        }

        public Room getStart()
        {
            return this.mid;
        }

        public Room getEnd()
        {
            return this.end;
        }

		public void generateDungeon()
		{
			Room curr = new Room (1);
            this.start = curr;
			dungeon[4].AddFirst(curr);

			curr = new Room (2);
			dungeon[3].AddFirst(curr);
			dungeon[7].AddFirst(curr);

			curr = new Room (3);
			dungeon[2].AddFirst(curr);
			dungeon[8].AddFirst(curr);
			dungeon[4].AddFirst(curr);

			curr = new Room (4);
			dungeon[3].AddFirst(curr);
			dungeon[5].AddFirst(curr);
			dungeon[1].AddFirst(curr);

			curr = new Room (5);
			dungeon[4].AddFirst(curr);
			dungeon[9].AddFirst(curr);
			dungeon[6].AddFirst(curr);

			curr = new Room (6);
			dungeon[10].AddFirst(curr);
			dungeon[5].AddFirst(curr);

			curr = new Room (7);
			dungeon[12].AddFirst(curr);
			dungeon[8].AddFirst(curr);
			dungeon[2].AddFirst(curr);

			curr = new Room (8);
			dungeon[13].AddFirst(curr);
			dungeon[7].AddFirst(curr);
			dungeon[3].AddFirst(curr);

			curr = new Room (9);
			dungeon[14].AddFirst(curr);
			dungeon[10].AddFirst(curr);
			dungeon[5].AddFirst(curr);

			curr = new Room (10);
			dungeon[15].AddFirst(curr);
			dungeon[9].AddFirst(curr);
			dungeon[6].AddFirst(curr);

			curr = new Room (11);
			dungeon[17].AddFirst(curr);
			dungeon[12].AddFirst(curr);

			curr = new Room (12);
			dungeon[7].AddFirst(curr);
			dungeon[11].AddFirst(curr);
			dungeon[18].AddFirst(curr);
			dungeon[13].AddFirst(curr);

			curr = new Room (13);
			dungeon[8].AddFirst(curr);
			dungeon[12].AddFirst(curr);
			dungeon[19].AddFirst(curr);

			curr = new Room (14);
			dungeon[9].AddFirst(curr);
			dungeon[15].AddFirst(curr);
			dungeon[20].AddFirst(curr);

			curr = new Room (15);
			dungeon[10].AddFirst(curr);
			dungeon[14].AddFirst(curr);
			dungeon[21].AddFirst(curr);
			dungeon[16].AddFirst(curr);

			curr = new Room (16);
			dungeon[15].AddFirst(curr);
			dungeon[22].AddFirst(curr);

            curr = new Room(17);
            dungeon[18].AddFirst(curr);
            dungeon[11].AddFirst(curr);

            curr = new Room(18);
            dungeon[17].AddFirst(curr);
            dungeon[12].AddFirst(curr);
            dungeon[19].AddFirst(curr);
            dungeon[23].AddFirst(curr);

            curr = new Room(19);
            dungeon[13].AddFirst(curr);
            dungeon[18].AddFirst(curr);
            dungeon[24].AddFirst(curr);

            curr = new Room(20);
            dungeon[14].AddFirst(curr);
            dungeon[21].AddFirst(curr);
            dungeon[26].AddFirst(curr);

            curr = new Room(21);
            dungeon[15].AddFirst(curr);
            dungeon[20].AddFirst(curr);
            dungeon[22].AddFirst(curr);
            dungeon[27].AddFirst(curr);

            curr = new Room(22);
            dungeon[21].AddFirst(curr);
            dungeon[16].AddFirst(curr);

            curr = new Room(23);
            dungeon[18].AddFirst(curr);
            dungeon[24].AddFirst(curr);

            curr = new Room(24);
            dungeon[19].AddFirst(curr);
            dungeon[23].AddFirst(curr);
            dungeon[25].AddFirst(curr);
            dungeon[28].AddFirst(curr);

            curr = new Room(25);
            dungeon[24].AddFirst(curr);
            dungeon[26].AddFirst(curr);
            dungeon[29].AddFirst(curr);

            curr = new Room(26);
            dungeon[20].AddFirst(curr);
            dungeon[25].AddFirst(curr);
            dungeon[27].AddFirst(curr);
            dungeon[30].AddFirst(curr);

            curr = new Room(27);
            dungeon[26].AddFirst(curr);
            dungeon[21].AddFirst(curr);

            curr = new Room(28);
            dungeon[24].AddFirst(curr);
            dungeon[29].AddFirst(curr);

            curr = new Room(29);
            dungeon[25].AddFirst(curr);
            dungeon[28].AddFirst(curr);
            dungeon[30].AddFirst(curr);
            dungeon[31].AddFirst(curr);

            curr = new Room(30);
            dungeon[26].AddFirst(curr);
            dungeon[29].AddFirst(curr);

            curr = new Room(31);
            this.mid = curr;
            dungeon[29].AddFirst(curr);
            dungeon[35].AddFirst(curr);

            curr = new Room(32);
            dungeon[33].AddFirst(curr);
            dungeon[39].AddFirst(curr);

            curr = new Room(33);
            dungeon[32].AddFirst(curr);
            dungeon[34].AddFirst(curr);
            dungeon[40].AddFirst(curr);

            curr = new Room(34);
            dungeon[33].AddFirst(curr);
            dungeon[41].AddFirst(curr);
            dungeon[35].AddFirst(curr);

            curr = new Room(35);
            dungeon[31].AddFirst(curr);
            dungeon[34].AddFirst(curr);
            dungeon[36].AddFirst(curr);
            dungeon[42].AddFirst(curr);

            curr = new Room(36);
            dungeon[35].AddFirst(curr);
            dungeon[37].AddFirst(curr);
            dungeon[43].AddFirst(curr);

            curr = new Room(37);
            dungeon[36].AddFirst(curr);
            dungeon[38].AddFirst(curr);
            dungeon[44].AddFirst(curr);

            curr = new Room(38);
            dungeon[37].AddFirst(curr);
            dungeon[45].AddFirst(curr);

            curr = new Room(39);
            dungeon[32].AddFirst(curr);
            dungeon[40].AddFirst(curr);

            curr = new Room(40);
            dungeon[39].AddFirst(curr);
            dungeon[33].AddFirst(curr);
            dungeon[46].AddFirst(curr);
            dungeon[41].AddFirst(curr);

            curr = new Room(41);
            dungeon[34].AddFirst(curr);
            dungeon[40].AddFirst(curr);
            dungeon[42].AddFirst(curr);
            dungeon[47].AddFirst(curr);

            curr = new Room(42);
            dungeon[35].AddFirst(curr);
            dungeon[41].AddFirst(curr);
            dungeon[43].AddFirst(curr);
            dungeon[48].AddFirst(curr);

            curr = new Room(43);
            dungeon[36].AddFirst(curr);
            dungeon[42].AddFirst(curr);
            dungeon[44].AddFirst(curr);
            dungeon[49].AddFirst(curr);

            curr = new Room(44);
            dungeon[37].AddFirst(curr);
            dungeon[43].AddFirst(curr);
            dungeon[45].AddFirst(curr);
            dungeon[50].AddFirst(curr);

            curr = new Room(45);
            dungeon[44].AddFirst(curr);
            dungeon[38].AddFirst(curr);

            curr = new Room(46);
            dungeon[40].AddFirst(curr);
            dungeon[47].AddFirst(curr);

            curr = new Room(47);
            dungeon[41].AddFirst(curr);
            dungeon[46].AddFirst(curr);
            dungeon[51].AddFirst(curr);
            dungeon[48].AddFirst(curr);

            curr = new Room(48);
            dungeon[42].AddFirst(curr);
            dungeon[47].AddFirst(curr);
            dungeon[49].AddFirst(curr);
            dungeon[52].AddFirst(curr);

            curr = new Room(49);
            dungeon[43].AddFirst(curr);
            dungeon[48].AddFirst(curr);
            dungeon[50].AddFirst(curr);
            dungeon[53].AddFirst(curr);

            curr = new Room(50);
            dungeon[49].AddFirst(curr);
            dungeon[44].AddFirst(curr);

            curr = new Room(51);
            dungeon[47].AddFirst(curr);
            dungeon[52].AddFirst(curr);

            curr = new Room(52);
            dungeon[54].AddFirst(curr);
            dungeon[51].AddFirst(curr);
            dungeon[53].AddFirst(curr);
            dungeon[48].AddFirst(curr);

            curr = new Room(53);
            dungeon[52].AddFirst(curr);
            dungeon[49].AddFirst(curr);

            curr = new Room(54);
            this.end = curr;
            dungeon[52].AddFirst(curr);
		}
	}
}