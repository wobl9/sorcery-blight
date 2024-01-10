using System;

namespace Skills
{
    [Serializable]
    public class Punch : Attack
    {
        public override string id => "Punch";
        public override int Damage => 5;
        public override int Cooldown
        {
            get => 0;
            protected set { }
        }

        public Punch() {}
    }
}