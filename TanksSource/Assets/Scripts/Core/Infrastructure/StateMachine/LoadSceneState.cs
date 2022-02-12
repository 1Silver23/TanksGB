using TanksGB.Core.Infrastructure.Services;
using TanksGB.Core.Infrastructure.Services.Factories;
using TanksGB.General.UI;

namespace TanksGB.Core.Infrastructure.StateMachine
{
    public sealed class LoadSceneState : ILoadingState<string>
    {
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;
        private readonly LoadingScreen _loadingCurtain;
        private readonly IGameFactory _gameFactory;
        private readonly IStaticDataService _dataService;
        private string _sceneName;

        public LoadSceneState(GameStateMachine stateMachine, SceneLoader sceneLoader, LoadingScreen loadingCurtain,
            IGameFactory gameFactory, IStaticDataService dataService)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
            _loadingCurtain = loadingCurtain;
            _gameFactory = gameFactory;
            _dataService = dataService;
        }

        public void Enter(string scene)
        {
            _sceneName = scene;
            _loadingCurtain.Show();
            _sceneLoader.Load(scene, OnSceneLoaded);
        }

        private void OnSceneLoaded()
        {
            _dataService.Load();
            _gameFactory.CreateGameController(_dataService.GetData(_sceneName));
            _stateMachine.Enter<GameLoopState>();
        }

        public void Exit() => _loadingCurtain.Hide();
    }
}