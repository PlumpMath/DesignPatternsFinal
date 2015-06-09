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
        private String description;

        public Room(int roomNum)
        {
            this.roomNum = roomNum;
        }
		public Room(int roomNum, String desc)
		{
			this.roomNum = roomNum;
			this.description = desc;
		}
        public Room(int roomNum, Event e)
        {
            this.roomNum = roomNum;
            this.t = e;
        }
        public Room(int roomNum, Event e, String des)
        {
            this.roomNum = roomNum;
            this.t = e;
            this.description = des;
        }
        public void arrive()
        {
            if(t!=null)
                this.t.onTrigger(roomNum);
        }
        public int getRoomNum()
        {
            return this.roomNum;
        }

        public String toString()
        {
            return "room #" + roomNum;
        }
        public String getDes()
        {
            return description;
        }
    }
}
