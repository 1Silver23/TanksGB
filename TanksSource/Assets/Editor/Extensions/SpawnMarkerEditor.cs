using TanksGB.General.LevelDesign;
using UnityEditor;
using UnityEngine;

namespace TanksGB.Editor.Extensions
{
    [UnityEditor.CustomEditor(typeof(TankSpawnMarker))]
    public sealed class SpawnMarkerEditor:UnityEditor.Editor
    {
        [DrawGizmo(GizmoType.Active | GizmoType.Pickable | GizmoType.NonSelected)]
        public static void RenderCustomGizmo(TankSpawnMarker tankSpawnMarker, GizmoType gizmo)
        {
            if (tankSpawnMarker.Type == TeamType.Blue)
                Gizmos.color = Color.blue;
            else Gizmos.color = Color.red;
            Gizmos.DrawSphere(tankSpawnMarker.transform.position, 0.5f);
        }
    }
}