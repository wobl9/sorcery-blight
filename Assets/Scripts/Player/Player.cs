using System;

[Serializable]
public class Player
{
    private int _maxHp;
    private int _hp;
    private int _experience;

    public string name;
    public int strength;
    public int MaxHp => _maxHp;
    public int Hp => _hp;
    public int defense;
    public int level;
    public int Experience => _experience;


    public event Action OnPlayerDied;
    public event Action OnPLayerLevelUp;

    public Player(string name)
    {
        this.name = name;
        strength = 1;
        SetMaxHp(100);
        SetHp(100);
        defense = 1;
        level = 1;
        _experience = 0;
    }

    public Player(
        string name,
        int strength,
        int maxHp,
        int hp,
        int defense,
        int level,
        int experience
    )
    {
        this.name = name;
        this.strength = strength;
        SetMaxHp(maxHp);
        SetHp(hp);
        this.defense = defense;
        this.level = level;
        IncreaseExperience(experience);
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

    public void IncreaseExperience(int value)
    {
        var requiredExpForLevelUp = ExperienceForLevelUp.GetExperienceForLevelUp(level);
        var newExp = value + _experience;
        if (requiredExpForLevelUp <= newExp)
        {
            LevelUp();
            var extraExperience = newExp - requiredExpForLevelUp;
            _experience = 0;
            IncreaseExperience(extraExperience);
        }
        else
        {
            _experience += value;
        }
    }

    private void SetHp(int value)
    {
        var newHp = value > MaxHp ? MaxHp : value;
        _hp = newHp;
    }

    private void LevelUp()
    {
        level++;
        OnPLayerLevelUp?.Invoke();
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