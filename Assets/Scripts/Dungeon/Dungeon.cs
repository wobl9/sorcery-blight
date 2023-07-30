using System;
using System.Collections.Generic;

[Serializable]
public class Dungeon
{
    public List<Room> rooms;
    public Room currentRoom;
    public Dungeon(RoomFactory roomFactory)
    {
        rooms = roomFactory.GenerateRooms();
    }

    public Dungeon(List<Room> rooms)
    {
        this.rooms = rooms;
    }
}