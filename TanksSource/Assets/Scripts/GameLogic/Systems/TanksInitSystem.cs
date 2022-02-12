using Entitas;
using TanksGB.Data;
using UnityEngine;

namespace TanksGB.GameLogic.Systems
{
    public sealed class TanksInitSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly SceneStaticData _staticData;

        public TanksInitSystem(Contexts contexts, SceneStaticData staticData)
        {
            _contexts = contexts;
            _staticData = staticData;
        }

        public void Initialize()
        {
            for (int i = 0; i < _staticData.TankSpawners.Count; i++)
            {
                var tankInstance = Object.Instantiate(_staticData.TankPrefab);
                tankInstance.transform.position = _staticData.TankSpawners[i].Position;
                int next = i + 1;
                if (next > _staticData.TankSpawners.Count - 1)
                    next -= _staticData.TankSpawners.Count;
                tankInstance.transform.LookAt(_staticData.TankSpawners[next].Position);
            }
        }
    }
}