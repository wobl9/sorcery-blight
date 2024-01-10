using System;

namespace Skills
{
    [Serializable]
    public abstract class Skill
    {
        public abstract String id { get; }
        public abstract int Cooldown { get; protected set; }

        public void Invoke(Character.Character target)
        {
            ApplyEffect(target);
            ReduceCooldown(1);
        }

        protected abstract void ApplyEffect(Character.Character target);

        void ReduceCooldown(int amount)
        {
            if (Cooldown > amount)
            {
                Cooldown -= amount;
            }
            else
            {
                Cooldown = 0;
            }
        }
    }
}