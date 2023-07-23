using System.Collections.Generic;

namespace Dungeon
{
    public class Dungeon
    {
        private const int DefaultRoomsNumber = 6;
        public List<Room> Rooms;
        public Room CurrentRoom;

        public Dungeon()
        {
            Rooms = GenerateRooms(DefaultRoomsNumber);
        }

        public Dungeon(List<Room> rooms)
        {
            Rooms = rooms;
        }

        public static List<Room> GenerateRooms(int count)
        {
            var rooms = new List<Room>();
            for (int i = 0; i < count; i++)
            {
                rooms.Add(new Room(i));
            }
            return rooms;
        }

        public static List<Room> GenerateRooms(List<Room> rooms)
        {
            var newRooms = new List<Room>(rooms);
            while (newRooms.Count < DefaultRoomsNumber)
            {
                newRooms.Add(new Room(1));
            }
            return newRooms;
        }

        public void SetCurrentRoom(Room room)
        {
            CurrentRoom = room;
        }
    }
}