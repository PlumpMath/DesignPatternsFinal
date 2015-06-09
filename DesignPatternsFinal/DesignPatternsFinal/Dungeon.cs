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
            BattleEvent b = new BattleEvent(theWorld.heroParty, null);

			Room curr = new Room(1, "Entrance");
            this.start = curr;
            dungeon[4].AddFirst(curr);

            curr = new Room(2, b, "Green Room");
            dungeon[3].AddFirst(curr);
            dungeon[7].AddFirst(curr);

			curr = new Room(3, b, "Red Room");
            dungeon[2].AddFirst(curr);
            dungeon[8].AddFirst(curr);
            dungeon[4].AddFirst(curr);

			curr = new Room(4, b, "Yellow Room");
            dungeon[3].AddFirst(curr);
            dungeon[5].AddFirst(curr);
            dungeon[1].AddFirst(curr);

			curr = new Room(5, b, "Blue Room");
            dungeon[4].AddFirst(curr);
            dungeon[9].AddFirst(curr);
            dungeon[6].AddFirst(curr);

			curr = new Room(6, b, "Black Room");
            dungeon[10].AddFirst(curr);
            dungeon[5].AddFirst(curr);

			curr = new Room(7, b, "White Room");
            dungeon[12].AddFirst(curr);
            dungeon[8].AddFirst(curr);
            dungeon[2].AddFirst(curr);

			curr = new Room(8, b, "Pink Room");
            dungeon[13].AddFirst(curr);
            dungeon[7].AddFirst(curr);
            dungeon[3].AddFirst(curr);

			curr = new Room(9, b, "Purple Room");
            dungeon[14].AddFirst(curr);
            dungeon[10].AddFirst(curr);
            dungeon[5].AddFirst(curr);

			curr = new Room(10, b, "Happy Room");
            dungeon[15].AddFirst(curr);
            dungeon[9].AddFirst(curr);
            dungeon[6].AddFirst(curr);

			curr = new Room(11, b, "Sad Room");
            dungeon[17].AddFirst(curr);
            dungeon[12].AddFirst(curr);

			curr = new Room(12, b, "Cool Room");
            dungeon[7].AddFirst(curr);
            dungeon[11].AddFirst(curr);
            dungeon[18].AddFirst(curr);
            dungeon[13].AddFirst(curr);

			curr = new Room(13, b, "Snowy Room");
            dungeon[8].AddFirst(curr);
            dungeon[12].AddFirst(curr);
            dungeon[19].AddFirst(curr);

			curr = new Room(14, b, "Sunny Room");
            dungeon[9].AddFirst(curr);
            dungeon[15].AddFirst(curr);
            dungeon[20].AddFirst(curr);

			curr = new Room(15, b, "Small Courtyard");
            dungeon[10].AddFirst(curr);
            dungeon[14].AddFirst(curr);
            dungeon[21].AddFirst(curr);
            dungeon[16].AddFirst(curr);

			curr = new Room(16, b, "Greenhouse Room");
            dungeon[15].AddFirst(curr);
            dungeon[22].AddFirst(curr);

			curr = new Room(17, b, "The Den");
            dungeon[18].AddFirst(curr);
            dungeon[11].AddFirst(curr);

			curr = new Room(18, b, "The Study");
            dungeon[17].AddFirst(curr);
            dungeon[12].AddFirst(curr);
            dungeon[19].AddFirst(curr);
            dungeon[23].AddFirst(curr);

			curr = new Room(19, b, "The Great Hall");
            dungeon[13].AddFirst(curr);
            dungeon[18].AddFirst(curr);
            dungeon[24].AddFirst(curr);

			curr = new Room(20, b, "Zeus's Bedroom");
            dungeon[14].AddFirst(curr);
            dungeon[21].AddFirst(curr);
            dungeon[26].AddFirst(curr);

			curr = new Room(21, b, "Hades's Bedroom");
            dungeon[15].AddFirst(curr);
            dungeon[20].AddFirst(curr);
            dungeon[22].AddFirst(curr);
            dungeon[27].AddFirst(curr);

			curr = new Room(22, b, "Nemesis' Bedroom");
            dungeon[21].AddFirst(curr);
            dungeon[16].AddFirst(curr);

			curr = new Room(23, b, "Nike's Bedroom");
            dungeon[18].AddFirst(curr);
            dungeon[24].AddFirst(curr);

			curr = new Room(24, b, "Game Room");
            dungeon[19].AddFirst(curr);
            dungeon[23].AddFirst(curr);
            dungeon[25].AddFirst(curr);
            dungeon[28].AddFirst(curr);

			curr = new Room(25, b, "Little Cavern");
            dungeon[24].AddFirst(curr);
            dungeon[26].AddFirst(curr);
            dungeon[29].AddFirst(curr);

			curr = new Room(26, b, "Big Cavern");
            dungeon[20].AddFirst(curr);
            dungeon[25].AddFirst(curr);
            dungeon[27].AddFirst(curr);
            dungeon[30].AddFirst(curr);

			curr = new Room(27, b, "Dungeon");
            dungeon[26].AddFirst(curr);
            dungeon[21].AddFirst(curr);

			curr = new Room(28, b, "Jail Cell");
            dungeon[24].AddFirst(curr);
            dungeon[29].AddFirst(curr);

			curr = new Room(29, b, "Kitchen");
            dungeon[25].AddFirst(curr);
            dungeon[28].AddFirst(curr);
            dungeon[30].AddFirst(curr);
            dungeon[31].AddFirst(curr);

			curr = new Room(30, b, "Closet");
            dungeon[26].AddFirst(curr);
            dungeon[29].AddFirst(curr);

			curr = new Room(31, b, "Cerberus' Lair");
            this.mid = curr;
            dungeon[29].AddFirst(curr);
            dungeon[35].AddFirst(curr);

			curr = new Room(32, b, "Small Guest Room");
            dungeon[33].AddFirst(curr);
            dungeon[39].AddFirst(curr);

			curr = new Room(33, b, "Crazy Clown Room");
            dungeon[32].AddFirst(curr);
            dungeon[34].AddFirst(curr);
            dungeon[40].AddFirst(curr);

			curr = new Room(34, b, "The Conservatory");
            dungeon[33].AddFirst(curr);
            dungeon[41].AddFirst(curr);
            dungeon[35].AddFirst(curr);

			curr = new Room(35, b, "Dining Room");
            dungeon[31].AddFirst(curr);
            dungeon[34].AddFirst(curr);
            dungeon[36].AddFirst(curr);
            dungeon[42].AddFirst(curr);

			curr = new Room(36, b, "Music Room");
            dungeon[35].AddFirst(curr);
            dungeon[37].AddFirst(curr);
            dungeon[43].AddFirst(curr);

			curr = new Room(37, b, "The Smelly Room");
            dungeon[36].AddFirst(curr);
            dungeon[38].AddFirst(curr);
            dungeon[44].AddFirst(curr);

			curr = new Room(38, b, "The Nursery");
            dungeon[37].AddFirst(curr);
            dungeon[45].AddFirst(curr);

			curr = new Room(39, b, "Monster Nest");
            dungeon[32].AddFirst(curr);
            dungeon[40].AddFirst(curr);

			curr = new Room(40, b, "Card Room");
            dungeon[39].AddFirst(curr);
            dungeon[33].AddFirst(curr);
            dungeon[46].AddFirst(curr);
            dungeon[41].AddFirst(curr);

			curr = new Room(41, b, "The Danger Zone");
            dungeon[34].AddFirst(curr);
            dungeon[40].AddFirst(curr);
            dungeon[42].AddFirst(curr);
            dungeon[47].AddFirst(curr);

			curr = new Room(42, b, "Dark Room");
            dungeon[35].AddFirst(curr);
            dungeon[41].AddFirst(curr);
            dungeon[43].AddFirst(curr);
            dungeon[48].AddFirst(curr);

			curr = new Room(43, b, "Light Room");
            dungeon[36].AddFirst(curr);
            dungeon[42].AddFirst(curr);
            dungeon[44].AddFirst(curr);
            dungeon[49].AddFirst(curr);

			curr = new Room(44, b, "The Balcony");
            dungeon[37].AddFirst(curr);
            dungeon[43].AddFirst(curr);
            dungeon[45].AddFirst(curr);
            dungeon[50].AddFirst(curr);

			curr = new Room(45, b, "The Roof");
            dungeon[44].AddFirst(curr);
            dungeon[38].AddFirst(curr);

			curr = new Room(46, b, "Bathroom");
            dungeon[40].AddFirst(curr);
            dungeon[47].AddFirst(curr);

			curr = new Room(47, b, "Gym");
            dungeon[41].AddFirst(curr);
            dungeon[46].AddFirst(curr);
            dungeon[51].AddFirst(curr);
            dungeon[48].AddFirst(curr);

			curr = new Room(48, b, "Ballroom");
            dungeon[42].AddFirst(curr);
            dungeon[47].AddFirst(curr);
            dungeon[49].AddFirst(curr);
            dungeon[52].AddFirst(curr);

			curr = new Room(49, b, "Billiard Room");
            dungeon[43].AddFirst(curr);
            dungeon[48].AddFirst(curr);
            dungeon[50].AddFirst(curr);
            dungeon[53].AddFirst(curr);

			curr = new Room(50, b, "Crazy Grandma's Room");
            dungeon[49].AddFirst(curr);
            dungeon[44].AddFirst(curr);

			curr = new Room(51, b, "Mystery Room");
            dungeon[47].AddFirst(curr);
            dungeon[52].AddFirst(curr);

			curr = new Room(52, b, "Do Not Enter");
            dungeon[54].AddFirst(curr);
            dungeon[51].AddFirst(curr);
            dungeon[53].AddFirst(curr);
            dungeon[48].AddFirst(curr);

			curr = new Room(53, b, "The Violent Room");
            dungeon[52].AddFirst(curr);
            dungeon[49].AddFirst(curr);

			curr = new Room(54, b, "The Final Room");
            this.end = curr;
            dungeon[52].AddFirst(curr);
            current = start;
        }
    }
}
