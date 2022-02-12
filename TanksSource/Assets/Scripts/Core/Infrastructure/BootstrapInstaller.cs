using TanksGB.Core.Infrastructure.Services;
using TanksGB.Core.Infrastructure.Services.Factories;
using Zenject;

namespace TanksGB.Core.Infrastructure
{
    public class BootstrapInstaller:MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IGameFactory>().To<GameFactory>().AsSingle();
            Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
        }
    }
}