using TanksGB.Data;

namespace TanksGB.GameLogic.Systems
{
    public sealed class InitSystems : Feature
    {
        public InitSystems(Contexts contexts, SceneStaticData staticData)
        {
            Add(new TanksInitSystem(contexts, staticData));
        }
    }
}