using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector.Editor;
using TanksGB.Data;
using TanksGB.General.LevelDesign;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TanksGB.Editor.Extensions.StaticData
{
    [UnityEditor.CustomEditor(typeof(SceneStaticData))]
    public class SceneStaticDataEditor : OdinEditor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            SceneStaticData sceneData = (SceneStaticData) target;
            if (GUILayout.Button("Initialize"))
                InitializeSceneData(sceneData);
        }

        private void InitializeSceneData(SceneStaticData sceneData)
        {
            string currentScene = SceneManager.GetActiveScene().name;
            if (!sceneData.name.Contains(currentScene))
            {
                Debug.LogError($"The SceneData is not for {currentScene}");
                return;
            }
            sceneData.LevelKey = currentScene;
            sceneData.TankSpawners = FindObjectsOfType<TankSpawnMarker>()
                .Select(x => new TankSpawnerData(x.Type, x.transform.position))
                .ToList();
            EditorUtility.SetDirty(target);
            Debug.Log($"SceneData of {currentScene} initialized");
        }
    }
}