using System;

namespace Character
{
    public interface IHpStats
    {
        public int MaxHp { get; }
        public int Hp { get; }
        public event Action OnPlayerDied;
        public void IncreaseMaxHp(int value);
        public void DecreaseMaxHp(int value);
        public void IncreaseHp(int value);
        public void DecreaseHp(int value);
    }
}