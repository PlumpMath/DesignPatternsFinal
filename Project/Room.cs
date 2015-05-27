using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class Room
    {
        private int roomNum;

        public Room(int roomNum)
        {
            this.roomNum = roomNum;
        }

        public int getRoomNum()
        {
            return this.roomNum;
        }

        public String toString()
        {
            return "room #" + roomNum;
        }
    }
}
