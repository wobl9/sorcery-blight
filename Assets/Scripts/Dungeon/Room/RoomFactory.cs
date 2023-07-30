using System.Collections.Generic;

public class RoomFactory
{
    private const int DefaultRoomsNumber = 6;
    private EncounterFactory _encounterFactory;

    public RoomFactory(EncounterFactory encounterFactory)
    {
        _encounterFactory = encounterFactory;
    }

    public Room GenerateRoom(int id)
    {
        return new Room(id, _encounterFactory);
    }
    
    public List<Room> GenerateRooms(int count = DefaultRoomsNumber)
    {
        var rooms = new List<Room>();
        for (int i = 0; i < count; i++)
        {
            rooms.Add(new Room(i, _encounterFactory));
        }

        return rooms;
    }

    public List<Room> GenerateRooms(List<Room> rooms)
    {
        var newRooms = new List<Room>(rooms);
        while (newRooms.Count < DefaultRoomsNumber)
        {
            newRooms.Add(new Room(1, _encounterFactory));
        }

        return newRooms;
    }
}