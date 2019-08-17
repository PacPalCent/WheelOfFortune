using Common;
using UnityEngine;
using UnityEngine.UI;

namespace Menu
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        
        private void Start()
        {
            _startButton.onClick.AddListener(LoadLevelSystem.LoadWheelScene);
        }

        private void OnDestroy()
        {
            _startButton.onClick.RemoveAllListeners();
        }
    }
}
