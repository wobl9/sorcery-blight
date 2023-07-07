namespace Character
{
    public interface IExperienceStats
    {
        public int Level { get; }
        public int Experience { get; }
        public void IncreaseExperience(int value);
        public void LevelUp();

        public static int GetExperienceForLevelUp(int currentLevel)
        {
            return currentLevel * 100;
        }
    }
}