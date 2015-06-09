using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class Dungeon : LinkedList<Room>
    {
        private static World theWorld;
        LinkedList<Room>[] dungeon;
        Room current;
        Room mid;
        Room start;
        Room end;

        public Dungeon(World world)
        {
            theWorld = world;
            this.dungeon = new LinkedList<Room>[55];
            for (int i = 0; i < dungeon.Length; i++)
            {
                dungeon[i] = new LinkedList<Room>();
            }
        }
        public Room[] adjacent()
        {
            return dungeon[current.getRoomNum()].ToArray();
        }
        public String moveTo(Room there)
        {
            current = there;
            current.arrive();
            return current.getDes();
        }

        public Room getCurrent()
        {
            return this.current;
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
            List<Character> them = new List<Character>();
            them.Add(new Hydra());
            them.Add(new Hydra());
            Party badguys = new Party(them);
            BattleEvent b = new BattleEvent(theWorld.heroParty, badguys);
			Room curr = new Room(1, "Entrance");
            this.start = curr;
            dungeon[4].AddFirst(curr);

            curr = new Room(2, b, "Green Room");
            dungeon[3].AddFirst(curr);
            dungeon[7].AddFirst(curr);

			curr = new Room(3, "Red Room");
            dungeon[2].AddFirst(curr);
            dungeon[8].AddFirst(curr);
            dungeon[4].AddFirst(curr);

            curr = new Room(4, "Yellow Room");
            dungeon[3].AddFirst(curr);
            dungeon[5].AddFirst(curr);
            dungeon[1].AddFirst(curr);

			curr = new Room(5, "Blue Room");
            dungeon[4].AddFirst(curr);
            dungeon[9].AddFirst(curr);
            dungeon[6].AddFirst(curr);

			curr = new Room(6, "Black Room");
            dungeon[10].AddFirst(curr);
            dungeon[5].AddFirst(curr);

			curr = new Room(7, "White Room");
            dungeon[12].AddFirst(curr);
            dungeon[8].AddFirst(curr);
            dungeon[2].AddFirst(curr);

			curr = new Room(8, "Pink Room");
            dungeon[13].AddFirst(curr);
            dungeon[7].AddFirst(curr);
            dungeon[3].AddFirst(curr);

			curr = new Room(9, "Purple Room");
            dungeon[14].AddFirst(curr);
            dungeon[10].AddFirst(curr);
            dungeon[5].AddFirst(curr);

			curr = new Room(10, "Happy Room");
            dungeon[15].AddFirst(curr);
            dungeon[9].AddFirst(curr);
            dungeon[6].AddFirst(curr);

			curr = new Room(11, "Sad Room");
            dungeon[17].AddFirst(curr);
            dungeon[12].AddFirst(curr);

			curr = new Room(12, "Cool Room");
            dungeon[7].AddFirst(curr);
            dungeon[11].AddFirst(curr);
            dungeon[18].AddFirst(curr);
            dungeon[13].AddFirst(curr);

			curr = new Room(13, "Snowy Room");
            dungeon[8].AddFirst(curr);
            dungeon[12].AddFirst(curr);
            dungeon[19].AddFirst(curr);

			curr = new Room(14, "Sunny Room");
            dungeon[9].AddFirst(curr);
            dungeon[15].AddFirst(curr);
            dungeon[20].AddFirst(curr);

            curr = new Room(15, "Small Courtyard");
            dungeon[10].AddFirst(curr);
            dungeon[14].AddFirst(curr);
            dungeon[21].AddFirst(curr);
            dungeon[16].AddFirst(curr);

            curr = new Room(16, "Greenhouse Room");
            dungeon[15].AddFirst(curr);
            dungeon[22].AddFirst(curr);

			curr = new Room(17, "The Den");
            dungeon[18].AddFirst(curr);
            dungeon[11].AddFirst(curr);

			curr = new Room(18, "The Study");
            dungeon[17].AddFirst(curr);
            dungeon[12].AddFirst(curr);
            dungeon[19].AddFirst(curr);
            dungeon[23].AddFirst(curr);

			curr = new Room(19, "The Great Hall");
            dungeon[13].AddFirst(curr);
            dungeon[18].AddFirst(curr);
            dungeon[24].AddFirst(curr);

			curr = new Room(20, "Zeus's Bedroom");
            dungeon[14].AddFirst(curr);
            dungeon[21].AddFirst(curr);
            dungeon[26].AddFirst(curr);

			curr = new Room(21, "Hades's Bedroom");
            dungeon[15].AddFirst(curr);
            dungeon[20].AddFirst(curr);
            dungeon[22].AddFirst(curr);
            dungeon[27].AddFirst(curr);

			curr = new Room(22, "Nemesis' Bedroom");
            dungeon[21].AddFirst(curr);
            dungeon[16].AddFirst(curr);

			curr = new Room(23, "Nike's Bedroom");
            dungeon[18].AddFirst(curr);
            dungeon[24].AddFirst(curr);

			curr = new Room(24, "Game Room");
            dungeon[19].AddFirst(curr);
            dungeon[23].AddFirst(curr);
            dungeon[25].AddFirst(curr);
            dungeon[28].AddFirst(curr);

			curr = new Room(25, "Little Cavern");
            dungeon[24].AddFirst(curr);
            dungeon[26].AddFirst(curr);
            dungeon[29].AddFirst(curr);

			curr = new Room(26, "Big Cavern");
            dungeon[20].AddFirst(curr);
            dungeon[25].AddFirst(curr);
            dungeon[27].AddFirst(curr);
            dungeon[30].AddFirst(curr);

			curr = new Room(27, "Dungeon");
            dungeon[26].AddFirst(curr);
            dungeon[21].AddFirst(curr);

			curr = new Room(28, "Jail Cell");
            dungeon[24].AddFirst(curr);
            dungeon[29].AddFirst(curr);

			curr = new Room(29, "Kitchen");
            dungeon[25].AddFirst(curr);
            dungeon[28].AddFirst(curr);
            dungeon[30].AddFirst(curr);
            dungeon[31].AddFirst(curr);

			curr = new Room(30, "Closet");
            dungeon[26].AddFirst(curr);
            dungeon[29].AddFirst(curr);

			curr = new Room(31, "Cerberus' Lair");
            this.mid = curr;
            dungeon[29].AddFirst(curr);
            dungeon[35].AddFirst(curr);

			curr = new Room(32, "Small Guest Room");
            dungeon[33].AddFirst(curr);
            dungeon[39].AddFirst(curr);

			curr = new Room(33, "Crazy Clown Room");
            dungeon[32].AddFirst(curr);
            dungeon[34].AddFirst(curr);
            dungeon[40].AddFirst(curr);

			curr = new Room(34, "The Conservatory");
            dungeon[33].AddFirst(curr);
            dungeon[41].AddFirst(curr);
            dungeon[35].AddFirst(curr);

			curr = new Room(35, "Dining Room");
            dungeon[31].AddFirst(curr);
            dungeon[34].AddFirst(curr);
            dungeon[36].AddFirst(curr);
            dungeon[42].AddFirst(curr);

			curr = new Room(36, "Music Room");
            dungeon[35].AddFirst(curr);
            dungeon[37].AddFirst(curr);
            dungeon[43].AddFirst(curr);

			curr = new Room(37, "The Smelly Room");
            dungeon[36].AddFirst(curr);
            dungeon[38].AddFirst(curr);
            dungeon[44].AddFirst(curr);

			curr = new Room(38, "The Nursery");
            dungeon[37].AddFirst(curr);
            dungeon[45].AddFirst(curr);

			curr = new Room(39, "Monster Nest");
            dungeon[32].AddFirst(curr);
            dungeon[40].AddFirst(curr);

			curr = new Room(40, "Card Room");
            dungeon[39].AddFirst(curr);
            dungeon[33].AddFirst(curr);
            dungeon[46].AddFirst(curr);
            dungeon[41].AddFirst(curr);

			curr = new Room(41, "The Danger Zone");
            dungeon[34].AddFirst(curr);
            dungeon[40].AddFirst(curr);
            dungeon[42].AddFirst(curr);
            dungeon[47].AddFirst(curr);

			curr = new Room(42, "Dark Room");
            dungeon[35].AddFirst(curr);
            dungeon[41].AddFirst(curr);
            dungeon[43].AddFirst(curr);
            dungeon[48].AddFirst(curr);

			curr = new Room(43, "Light Room");
            dungeon[36].AddFirst(curr);
            dungeon[42].AddFirst(curr);
            dungeon[44].AddFirst(curr);
            dungeon[49].AddFirst(curr);

			curr = new Room(44, "The Balcony");
            dungeon[37].AddFirst(curr);
            dungeon[43].AddFirst(curr);
            dungeon[45].AddFirst(curr);
            dungeon[50].AddFirst(curr);

			curr = new Room(45, "The Roof");
            dungeon[44].AddFirst(curr);
            dungeon[38].AddFirst(curr);

			curr = new Room(46, "Bathroom");
            dungeon[40].AddFirst(curr);
            dungeon[47].AddFirst(curr);

			curr = new Room(47, "Gym");
            dungeon[41].AddFirst(curr);
            dungeon[46].AddFirst(curr);
            dungeon[51].AddFirst(curr);
            dungeon[48].AddFirst(curr);

			curr = new Room(48, "Ballroom");
            dungeon[42].AddFirst(curr);
            dungeon[47].AddFirst(curr);
            dungeon[49].AddFirst(curr);
            dungeon[52].AddFirst(curr);

			curr = new Room(49, "Billiard Room");
            dungeon[43].AddFirst(curr);
            dungeon[48].AddFirst(curr);
            dungeon[50].AddFirst(curr);
            dungeon[53].AddFirst(curr);

			curr = new Room(50, "Crazy Grandma's Room");
            dungeon[49].AddFirst(curr);
            dungeon[44].AddFirst(curr);

			curr = new Room(51, "Mystery Room");
            dungeon[47].AddFirst(curr);
            dungeon[52].AddFirst(curr);

			curr = new Room(52, "Do Not Enter");
            dungeon[54].AddFirst(curr);
            dungeon[51].AddFirst(curr);
            dungeon[53].AddFirst(curr);
            dungeon[48].AddFirst(curr);

			curr = new Room(53, "The Violent Room");
            dungeon[52].AddFirst(curr);
            dungeon[49].AddFirst(curr);

			curr = new Room(54, "The Final Room");
            this.end = curr;
            dungeon[52].AddFirst(curr);
            current = start;
        }
    }
}
