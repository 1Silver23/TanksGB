using TanksGB.Data;
using TanksGB.GameLogic;
using UnityEngine;

namespace TanksGB.Core.Infrastructure.Services.Factories
{
    public class GameFactory : IGameFactory
    {
        private const string c_gamecontroller = "GameController";

        public void CreateGameController(SceneStaticData staticData)
        {
            GameObject gameController = new GameObject(c_gamecontroller);
            gameController.AddComponent<GameController>().Construct(staticData);
        }
    }
}