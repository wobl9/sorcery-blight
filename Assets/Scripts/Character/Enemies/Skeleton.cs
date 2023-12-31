using System;

namespace Character.Enemies
{
    [Serializable]
    public class Skeleton : Enemy
    {
        public override string SpritePath => "Sprites/slime";
        public override string Name => "";
        public override IHpStats HpStats => new HpStatsImpl(10, 10);
        public override IExperienceStats ExpStats => new ExperienceStatsImpl(10);
        public override ICombatStats CombatStats => new CombatStatsImpl(2, 1);

        public Skeleton()
        {
        }
    }
}