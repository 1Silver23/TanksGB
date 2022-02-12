using System;
using TanksGB.General.LevelDesign;
using UnityEngine;

namespace TanksGB.Data
{
    [Serializable]
    public class TankSpawnerData
    {
        public TeamType Type;
        public Vector3 Position;

        public TankSpawnerData(TeamType type, Vector3 position)
        {
            Type = type;
            Position = position;
        }
    }
}