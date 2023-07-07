using System;

namespace Character
{
    [Serializable]
    public class HpStatsImpl : IHpStats
    {
        private int _maxHp;
        private int _hp;

        public int MaxHp => _maxHp;
        public int Hp => _hp;

        public event Action OnPlayerDied;

        public HpStatsImpl(int maxHp, int hp)
        {
            SetMaxHp(maxHp);
            SetHp(hp);
        }

        public void IncreaseMaxHp(int value)
        {
            _maxHp += value;
        }

        public void DecreaseMaxHp(int value)
        {
            _maxHp -= value;
            SetHp(_hp);
        }

        public void IncreaseHp(int value)
        {
            var possibleHp = value + Hp;
            var newHp = possibleHp > MaxHp ? MaxHp : possibleHp;
            _hp = newHp;
        }

        public void DecreaseHp(int value)
        {
            var newHp = Hp - value;
            if (newHp <= 0)
            {
                OnPlayerDied?.Invoke();
            }
            else
            {
                _hp = newHp;
            }
        }

        private void SetHp(int value)
        {
            var newHp = value > MaxHp ? MaxHp : value;
            _hp = newHp;
        }

        private void SetMaxHp(int value)
        {
            _maxHp = value;
            if (Hp < MaxHp)
            {
                _hp = MaxHp;
            }
        }
    }
}