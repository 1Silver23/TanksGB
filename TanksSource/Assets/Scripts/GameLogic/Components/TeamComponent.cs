using Entitas;
using TanksGB.General.LevelDesign;

namespace TanksGB.GameLogic.Components
{
    [Game]
    public sealed class TeamComponent : IComponent
    {
        public TeamType Team;
    }
}