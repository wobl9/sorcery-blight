using System;
using System.Collections.Generic;
using Character.Enemies;

[Serializable]
public class Room
{
    public int id;
    public List<RoomEncounter> Encounters { get; private set; }
    public Enemy Enemy { get; private set; }

    public Room(int id, EncounterFactory encounterFactory, EnemiesFactory enemiesFactory)
    {
        this.id = id;
        Encounters = encounterFactory.GenerateEncounters();
        Enemy = enemiesFactory.Create();
    }
}