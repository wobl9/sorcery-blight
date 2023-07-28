using System;
using System.Collections.Generic;

[Serializable]
public class Dungeon
{
    private const int DefaultRoomsNumber = 6;
    public List<Room> rooms;
    public Room currentRoom;
    public Dungeon()
    {
        rooms = GenerateRooms(DefaultRoomsNumber);
    }

    public Dungeon(List<Room> rooms)
    {
        this.rooms = rooms;
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
}