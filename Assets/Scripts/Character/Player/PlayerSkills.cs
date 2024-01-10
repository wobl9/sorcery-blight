using System;
using System.Collections.Generic;
using Skills;

namespace Character
{
    [Serializable]
    public class PlayerSkills
    {
        public Dictionary<String, Skill> AllSkills = new();

        public PlayerSkills()
        {
            AddSkill(new Punch());
        }

        public void AddSkill(Skill skill)
        {
            AllSkills[skill.id] = skill;
        }
    }
}