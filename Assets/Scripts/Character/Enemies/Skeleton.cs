using System;

namespace Character.Enemies
{
    [Serializable]
    public class Skeleton : Enemy
    {
        public override string SpritePath => "Sprites/slime";
        public override string Name => "Skeleton";

        public Skeleton() : base(12, 12, 2,2)
        {
        }
    }
}