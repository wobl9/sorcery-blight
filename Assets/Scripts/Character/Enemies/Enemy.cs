using System;
using UnityEngine;

namespace Character.Enemies
{
    [Serializable]
    public abstract class Enemy : Character
    {
        public override string Name { get; }
        public override IHpStats HpStats { get; }
        public override ICombatStats CombatStats { get; }

        public Enemy(
            int maxHp,
            int hp,
            int strength,
            int defense
        )
        {
            IHpStats hpStats = new HpStatsImpl(maxHp, hp);
            CombatStats = new CombatStatsImpl(strength, defense);
            HpStats = hpStats;
            hpStats.OnDeath += OnDeath;
        }

        private void OnDeath()
        {
            Debug.Log("Enemy " + Name + " is dead");
        }
    }
}