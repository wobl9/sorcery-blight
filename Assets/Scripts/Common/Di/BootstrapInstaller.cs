using Common.ResourceProviders;
using utils.save;
using Zenject;

namespace Common.Di
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindSaveSystem();
            BindImageProvider();
            BindGameState();
            BindDugeonFactory();
            BindRoomFactory();
            BindRoomEncounterFactory();
        }

        private void BindRoomEncounterFactory()
        {
            Container
                .Bind<EncounterFactory>()
                .FromNew()
                .AsTransient();
        }

        private void BindRoomFactory()
        {
            Container
                .Bind<RoomFactory>()
                .FromNew()
                .AsTransient();
        }

        private void BindDugeonFactory()
        {
            Container
                .Bind<DungeonFactory>()
                .FromNew()
                .AsTransient();
        }

        private void BindSaveSystem()
        {
            Container
                .Bind<ISaveSystem>()
                .To<BinarySaveSystem>()
                .FromInstance(new BinarySaveSystem())
                .AsSingle();
        }

        private void BindImageProvider()
        {
            Container
                .Bind<IImageProvider>()
                .To<LocalImageProvider>()
                .FromInstance(new LocalImageProvider())
                .AsSingle();
        }

        private void BindGameState()
        {
            Container
                .Bind<GameState>()
                .FromMethod(_ => ResolveGameState())
                .AsSingle();
        }

        private GameState ResolveGameState()
        {
            return Container.Resolve<ISaveSystem>().Load()?.GameState ?? new GameState();
        }
    }
}