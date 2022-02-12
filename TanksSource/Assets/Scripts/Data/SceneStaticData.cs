using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace TanksGB.Data
{
    [CreateAssetMenu(fileName = "SceneData", menuName = "Tanks/StaticData/Scene")]
    public class SceneStaticData : ScriptableObject
    {
        public string LevelKey;
        public List<TankSpawnerData> TankSpawners;
        [FoldoutGroup("Prefab"), PreviewField]
        public GameObject TankPrefab;
    }
}
