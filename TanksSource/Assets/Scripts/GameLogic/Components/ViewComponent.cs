using Entitas;
using UnityEngine;

namespace TanksGB.GameLogic.Components
{
    [Game]
    public sealed class ViewComponent : IComponent
    {
        public GameObject View;
    }
}