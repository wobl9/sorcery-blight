using Character;
using utils.save;
using Zenject;

namespace Common.Di
{
    public class DungeonScreenInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            GameState gameState = Container.Resolve<GameState>();
            BindPlayer(gameState);
            BindDungeon(gameState);
        }

        private void BindPlayer(GameState gameState)
        {
            Container
                .Bind<Player>()
                .FromInstance(gameState.Player)
                .AsSingle();
        }

        private void BindDungeon(GameState gameState)
        {
            Container
                .Bind<Dungeon>()
                .FromInstance(gameState.Dungeon)
                .AsSingle();
        }
    }
}