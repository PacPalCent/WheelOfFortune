using Common;
using UnityEngine;
using UnityEngine.UI;
using WheelOfFortune.Generator;

namespace Menu
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        
        private void Start()
        {
            _startButton.onClick.AddListener(StartButtonClick);
        }

        private void OnDestroy()
        {
            _startButton.onClick.RemoveAllListeners();
        }

        private void StartButtonClick()
        {
            LoadLevelSystem.LoadWheelScene();
            FortuneGenerator.Generate();
        }
    }
}
