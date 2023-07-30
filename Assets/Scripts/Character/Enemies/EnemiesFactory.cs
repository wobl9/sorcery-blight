namespace Character.Enemies
{
    public class EnemiesFactory
    {
        public Enemy Create()
        {
            return new Skeleton();
        }
    }
}