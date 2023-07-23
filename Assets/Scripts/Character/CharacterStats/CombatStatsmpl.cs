using System;

namespace Character
{
    [Serializable]
    public class CombatStatsImpl : ICombatStats
    {
        private readonly int _strength;
        private readonly int _defense;

        public int Strength => _strength;
        public int Defense => _defense;

        public CombatStatsImpl(int strength, int defense)
        {
            _strength = strength;
            _defense = defense;
        }
    }
}