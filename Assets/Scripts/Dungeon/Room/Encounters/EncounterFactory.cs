using System;
using System.Collections.Generic;
using System.Linq;
using Common.Utils;

public class EncounterFactory
{
    private const int DefaultEncountersCount = 4;
    private Random _random = new();

    private Type[] _encounters =
    {
        typeof(ReduceAttack),
        typeof(IncreaseAllDamage)
    };

    public List<RoomEncounter> GenerateEncounters(int maxCount = DefaultEncountersCount)
    {
        List<RoomEncounter> encounters = new();
        if (maxCount <= 0) return encounters;

        for (int i = 0; i < maxCount; i++)
        {
            if (i > 0)
            {
                if (ChanceUtils.HitChance())
                {
                    encounters.Add(GenerateEncounter());
                }
            }
        }

        return encounters.Distinct(RoomEncounter.RoomEncounterEqualityComparer.Default).ToList();
    }

    private RoomEncounter GenerateEncounter()
    {
        var encounter = _encounters[_random.Next(_encounters.Length)];
        return (RoomEncounter)Activator.CreateInstance(encounter);
    }
}