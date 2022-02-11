namespace TanksGB.General.Infrastructure.StateMachine
{
    public interface ILoadingState<TLoad> : IExitableState
    {
        void Enter(TLoad load);
    }
}