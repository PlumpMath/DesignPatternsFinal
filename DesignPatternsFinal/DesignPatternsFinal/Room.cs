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
        private Event t;

        public Room(int roomNum)
        {
            this.roomNum = roomNum;
        }
        public Room(int roomNum, Event e)
        {
            this.roomNum = roomNum;
            this.t = e;
        }
        public void arrive()
        {
            if(t!=null)
                this.t.onTrigger();
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
