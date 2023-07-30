public class DungeonFactory
{
    private RoomFactory _roomFactory;

    public DungeonFactory(
        RoomFactory roomFactory,
        EncounterFactory encounterFactory
    )
    {
        _roomFactory = roomFactory;
    }

    public Dungeon GenerateDungeon()
    {
        return new Dungeon(_roomFactory);
    }
}