using System;

namespace Character
{
    public interface IHpStats
    {
        public int MaxHp { get; }
        public int Hp { get; }
        public float HpInPercents { get; }
        public event Action<int> OnHealthChanged;
        public event Action OnDeath;
        public void IncreaseMaxHp(int value);
        public void DecreaseMaxHp(int value);
        public void IncreaseHp(int value);
        public void DecreaseHp(int value);
        public bool IsAlive();
    }
}