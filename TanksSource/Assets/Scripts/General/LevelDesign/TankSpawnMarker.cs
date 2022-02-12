using UnityEngine;

namespace TanksGB.General.LevelDesign
{
    public class TankSpawnMarker : MonoBehaviour
    {
        public TeamType Type;
    }

    public enum TeamType
    {
        Blue,
        Red
    }
}