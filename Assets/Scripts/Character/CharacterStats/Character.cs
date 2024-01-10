using System;
using UnityEngine;

namespace Character
{
    [Serializable]
    public abstract class Character
    {
        public abstract string SpritePath { get; }
        public abstract string Name { get; }
        public abstract IHpStats HpStats { get; }
        public abstract ICombatStats CombatStats { get; }

        public void Damage(int rawDamage)
        {
            if (rawDamage - CombatStats.Defense > 0 && HpStats.IsAlive())
            {
                int damage = rawDamage - CombatStats.Defense;
                Debug.Log("Character " + Name + " taken damage " + damage );
                HpStats.DecreaseHp(damage);
                Debug.Log("Character " + Name + " has hp " + HpStats.Hp );
            }
            else
            {
                Debug.Log("Damage to " + Name + " was fully blocked");
            }
        }
    }
}