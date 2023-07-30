using System;
using System.Collections.Generic;

[Serializable]
public abstract class RoomEncounter
{
    public abstract int ID { get; }
    public abstract string ImagePath { get; }
    public const string UnknownNumberOfEncounterPath = "Sprites/fireball";


    public class RoomEncounterEqualityComparer : IEqualityComparer<RoomEncounter>
    {
        public static readonly RoomEncounterEqualityComparer Default = new();

        public bool Equals(RoomEncounter x, RoomEncounter y)
        {
            if (x == null || y == null) return false;
            return x.ID == y.ID;
        }

        public int GetHashCode(RoomEncounter obj)
        {
            return obj.ID.GetHashCode();
        }
    }
}