using System.Collections.Generic;
using System.Linq;
using TanksGB.Data;
using UnityEngine;

namespace TanksGB.Core.Infrastructure.Services
{
    public sealed class StaticDataService : IStaticDataService
    {
        private Dictionary<string, SceneStaticData> _scenes;

        public void Load()
        {
            _scenes = Resources.LoadAll<SceneStaticData>(DataPaths.SCENE)
                .ToDictionary(x => x.LevelKey, x => x);
        }

        public SceneStaticData GetData(string sceneName) =>
            _scenes.TryGetValue(sceneName, out SceneStaticData staticData) ? staticData : null;
    }
}