using System;

namespace Dungeon
{
    [Serializable]
    public class Room
    {
        public int id;

        public Room(int id)
        {
            this.id = id;
        }
    }
}