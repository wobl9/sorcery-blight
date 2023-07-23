using Character;
using utils.save;
using Zenject;

namespace Common.Di
{
    public class DungeonScreenInstaller : MonoInstaller
    {
        private Player _player;

        public override void InstallBindings()
        {
            _player = Container.Resolve<ISaveSystem>().Load().player;
            Container.Bind<Player>().FromInstance(_player).AsSingle();
            BindDungeon();
        }
        
        private void BindDungeon()
        {
            Container
                .Bind<Dungeon.Dungeon>()
                .FromNew()
                .AsSingle();
        }
    }
}