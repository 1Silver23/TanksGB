using TanksGB.Core.Infrastructure.StateMachine;
using TanksGB.General.UI;
using UnityEngine;
using Zenject;

namespace TanksGB.Core.Infrastructure
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private LoadingScreen _loadingScreenPrefab;
        private Game _game;

        private void Awake()
        {
            CreateServices();
            DontDestroyOnLoad(this);
        }

        [Inject]
        private void OnContextRun(DiContainer services)
        {
            _game = new Game(SceneNames.MAIN, services, Instantiate(_loadingScreenPrefab));
            _game.StateMachine.Enter<BootstrapState>();
        }

        private void CreateServices()
        {
            SceneContext zenjectBootstrapContext = GetComponent<SceneContext>();
            zenjectBootstrapContext.Run();
        }
        
    }
}