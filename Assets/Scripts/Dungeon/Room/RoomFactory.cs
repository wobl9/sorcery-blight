using System.Collections.Generic;
using Character.Enemies;

public class RoomFactory
{
    private const int DefaultRoomsNumber = 6;
    private EncounterFactory _encounterFactory;
    private EnemiesFactory _enemiesFactory;

    public RoomFactory(EncounterFactory encounterFactory, EnemiesFactory enemiesFactory)
    {
        _encounterFactory = encounterFactory;
        _enemiesFactory = enemiesFactory;
    }

    public Room GenerateRoom(int id)
    {
        return new Room(id, _encounterFactory, _enemiesFactory);
    }
    
    public List<Room> GenerateRooms(int count = DefaultRoomsNumber)
    {
        var rooms = new List<Room>();
        for (int i = 0; i < count; i++)
        {
            rooms.Add(new Room(i, _encounterFactory, _enemiesFactory));
        }

        return rooms;
    }

    public List<Room> GenerateRooms(List<Room> rooms)
    {
        var newRooms = new List<Room>(rooms);
        while (newRooms.Count < DefaultRoomsNumber)
        {
            newRooms.Add(new Room(1, _encounterFactory, _enemiesFactory));
        }

        return newRooms;
    }
}