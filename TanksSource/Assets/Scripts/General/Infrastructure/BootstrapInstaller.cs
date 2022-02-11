using TanksGB.General.Infrastructure.Services.Factories;
using Zenject;

namespace TanksGB.General.Infrastructure
{
    public class BootstrapInstaller:MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IGameFactory>().To<GameFactory>().AsSingle();
        }
    }
}