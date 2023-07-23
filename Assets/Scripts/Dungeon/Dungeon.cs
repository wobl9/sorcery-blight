using System.Collections.Generic;

namespace Dungeon
{
    public class Dungeon
    {
        private const int DefaultRoomsNumber = 6;
        public List<Room> Rooms;

        void Setup()
        {
            Rooms = GenerateRooms(DefaultRoomsNumber);
        }

        public static List<Room> GenerateRooms(int count)
        {
            var rooms = new List<Room>();
            while (rooms.Count < count)
            {
                rooms.Add(Room.GenerateRoom());
            }
            return rooms;
        }

        public static List<Room> GenerateRooms(List<Room> rooms)
        {
            var newRooms = new List<Room>(rooms);
            while (newRooms.Count < DefaultRoomsNumber)
            {
                newRooms.Add(Room.GenerateRoom());
            }
            return newRooms;
        }
    }
}