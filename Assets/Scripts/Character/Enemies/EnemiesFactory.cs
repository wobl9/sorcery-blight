namespace Character.Enemies
{
    public class EnemiesFactory
    {
        static Enemy Create()
        {
            return new Skeleton();
        }
    }
}