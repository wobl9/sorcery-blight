using System;

namespace Skills
{
    [Serializable]
    public abstract class Attack: Skill
    {
        public abstract int Damage { get; }
        public abstract override int Cooldown { get; }
        
        protected override void ApplyEffect(Character.Character target)
        {
            target.Damage(Damage);
        }
    }
}