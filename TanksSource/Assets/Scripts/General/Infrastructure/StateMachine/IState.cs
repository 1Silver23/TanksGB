namespace TanksGB.General.Infrastructure.StateMachine
{
    public interface IState:IExitableState
    {
        void Enter();
    }
}