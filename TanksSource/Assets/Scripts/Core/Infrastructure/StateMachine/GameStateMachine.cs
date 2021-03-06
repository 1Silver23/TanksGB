using System;
using System.Collections.Generic;
using TanksGB.Core.Infrastructure.Services;
using TanksGB.Core.Infrastructure.Services.Factories;
using TanksGB.General.UI;
using Zenject;

namespace TanksGB.Core.Infrastructure.StateMachine
{
    public sealed class GameStateMachine
    {
        private readonly Dictionary<Type, IExitableState> _states;
        private IExitableState _currentState;

        public GameStateMachine(SceneLoader sceneLoader, string startScene, DiContainer services,
            LoadingScreen loadingCurtain)
        {
            _states = new Dictionary<Type, IExitableState>()
            {
                [typeof(BootstrapState)] = new BootstrapState(this, sceneLoader, startScene),
                [typeof(LoadSceneState)] = new LoadSceneState(this, sceneLoader, loadingCurtain,
                    services.Resolve<IGameFactory>(), services.Resolve<IStaticDataService>()),
                [typeof(GameLoopState)] = new GameLoopState(this)
            };
        }

        public void Enter<TState>() where TState : class, IState
        {
            TState state = ChangeState<TState>();
            state.Enter();
        }

        public void Enter<TState, TLoad>(TLoad sceneName) where TState : class, ILoadingState<TLoad>
        {
            TState state = ChangeState<TState>();
            state.Enter(sceneName);
        }

        private TState ChangeState<TState>() where TState : class, IExitableState
        {
            _currentState?.Exit();
            TState state = GetState<TState>();
            _currentState = state;
            return state;
        }

        private TState GetState<TState>() where TState : class, IExitableState => _states[typeof(TState)] as TState;
    }
}