using System;

namespace Dungeon
{
    [Serializable]
    public class Room
    {
        public static Room GenerateRoom()
        {
            return new Room();
        }
    }
}