using TanksGB.Data;
using TanksGB.GameLogic.Systems;
using UnityEngine;

namespace TanksGB.GameLogic
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private SceneStaticData _staticData;

        public void Construct(SceneStaticData staticData)
        {
            _staticData = staticData;
        }

        private void Start()
        {
            var contexts = Contexts.sharedInstance;
            InitSystems initSystems = new InitSystems(contexts, _staticData);
            initSystems.Initialize();
        }
    }
}