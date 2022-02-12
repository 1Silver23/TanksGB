using TanksGB.Data;

namespace TanksGB.Core.Infrastructure.Services
{
    public interface IStaticDataService : IService
    {
        void Load();
        SceneStaticData GetData(string sceneName);
    }
}