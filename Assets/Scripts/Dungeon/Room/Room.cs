using System;
using System.Collections.Generic;

[Serializable]
public class Room
{
    public int id;
    public List<RoomEncounter> Encounters { get; private set; }

    public Room(int id, EncounterFactory encounterFactory)
    {
        this.id = id;
        Encounters = encounterFactory.GenerateEncounters();
    }
}