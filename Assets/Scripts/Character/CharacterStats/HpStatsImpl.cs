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

        public float HpInPercents => (float)_hp / _maxHp;

        public event Action OnDeath;
        public event Action<int> OnHealthChanged;


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
            OnHealthChanged?.Invoke(_hp);
        }

        public void DecreaseHp(int value)
        {
            var newHp = Hp - value;
            if (newHp <= 0)
            {
                OnDeath?.Invoke();  
            }
            else
            {
                _hp = newHp;
                OnHealthChanged?.Invoke(_hp);
            }
        }

        private void SetHp(int value)
        {
            var newHp = value > MaxHp ? MaxHp : value;
            _hp = newHp;
            OnHealthChanged?.Invoke(_hp);
        }

        private void SetMaxHp(int value)
        {
            _maxHp = value;
            if (Hp < MaxHp)
            {
                _hp = MaxHp;
                OnHealthChanged?.Invoke(_hp);
            }
        }

        public bool IsAlive()
        {
            return _hp > 0;
        }
    }
}