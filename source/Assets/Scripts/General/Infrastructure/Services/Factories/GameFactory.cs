using TanksGB.GameLogic;
using UnityEngine;

namespace TanksGB.General.Infrastructure.Services.Factories
{
    public class GameFactory : IGameFactory
    {
        private const string c_gamecontroller = "GameController";

        public void CreateGameController()
        {
            GameObject controllerObject = new GameObject(c_gamecontroller, typeof(GameController));
        }
    }
}