using utils.save;
using Zenject;

namespace Common.Infrastructure
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindSaveSystem();
        }

        private void BindSaveSystem()
        {
            Container
                .Bind<ISaveSystem>()
                .To<BinarySaveSystem>()
                .FromInstance(new BinarySaveSystem())
                .AsSingle();
        }
    }
}