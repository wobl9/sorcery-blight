namespace Character
{
    public abstract class Character
    {
        public abstract string Name { get; }
        public abstract IHpStats HpStats { get; }
        public abstract IExperienceStats ExpStats { get; }
        public abstract ICombatStats CombatStats { get; }
    }
}