using System;
using Sirenix.OdinInspector;
using TanksGB.General.Infrastructure;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace TanksGB.General.UI
{
    public class StartMenu:MonoBehaviour
    {
        [SerializeField] private Bootstrapper _bootstrapperPrefab;
        private const string c_startBtn = "start_btn";

        private VisualElement _root;
        private Button _startButton;

        private void Awake()
        {
            _root = GetComponent<UIDocument>().rootVisualElement;
            _startButton = _root.Q<Button>(c_startBtn);
            _startButton.clicked += OnStartButtonClicked;
        }

        private void OnStartButtonClicked()
        {
            Instantiate(_bootstrapperPrefab);
        }

        private void OnDestroy()
        {
            _startButton.clicked -= OnStartButtonClicked;
        }
    }
}