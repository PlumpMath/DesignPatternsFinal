using System;

namespace DesignPatternsProject
{
	public class Room
	{
		private int roomNum;

		public Room ( int roomNum )
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

