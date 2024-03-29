using System;

namespace Character
{
    [Serializable]
    public class Player : Character
    {
        public override string SpritePath => "Sprites/spirit";
        public override string Name { get; }
        public override IHpStats HpStats { get; }
        public override ICombatStats CombatStats { get; }

        public int MaxHp => HpStats.MaxHp;
        public int Hp => HpStats.Hp;
        public int Strength => CombatStats.Strength;
        public int Defense => CombatStats.Defense;
        public int Level => ExpStats.Level;
        public int Experience => ExpStats.Experience;
        
        public IExperienceStats ExpStats { get; }
        public PlayerSkills Skills = new();

        public Player(string name)
        {
            Name = name;
            CombatStats = new CombatStatsImpl(1, 1);
            ExpStats = new ExperienceStatsImpl(0);
            HpStats = new HpStatsImpl(100, 100);
        }

        public Player(
            string name,
            int strength,
            int maxHp,
            int hp,
            int defense,
            int experience
        )
        {
            Name = name;
            CombatStats = new CombatStatsImpl(strength, defense);
            HpStats = new HpStatsImpl(maxHp, hp);
            ExpStats = new ExperienceStatsImpl(experience);
        }
    }
}