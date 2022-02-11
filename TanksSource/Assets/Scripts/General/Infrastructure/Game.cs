using TanksGB.General.Infrastructure.StateMachine;
using TanksGB.General.UI;
using Zenject;

namespace TanksGB.General.Infrastructure
{
    public sealed class Game
    {
        public GameStateMachine StateMachine;
        
        public Game(string startScene, DiContainer services, LoadingScreen loadingCurtain)
        {
            StateMachine = new GameStateMachine(new SceneLoader(),startScene, services, loadingCurtain);
        }
    }
}