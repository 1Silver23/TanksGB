using TanksGB.Data;

namespace TanksGB.Core.Infrastructure.Services.Factories
{
    public interface IGameFactory : IService
    {
        void CreateGameController(SceneStaticData staticData);
    }
}