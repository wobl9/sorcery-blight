using System;

namespace Character
{
    [Serializable]
    public class ExperienceStatsImpl : IExperienceStats
    {
        private int _experience;
        private int _level = 1;

        public int Level => _level;
        public int Experience => _experience;

        public event Action OnPLayerLevelUp;

        public ExperienceStatsImpl(int experience)
        {
            IncreaseExperience(experience);
        }

        public void IncreaseExperience(int value)
        {
            var requiredExpForLevelUp = IExperienceStats.GetExperienceForLevelUp(_level);
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

        public void LevelUp()
        {
            _level++;
            OnPLayerLevelUp?.Invoke();
        }
    }
}