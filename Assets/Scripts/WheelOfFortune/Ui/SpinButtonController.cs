using UnityEngine;
using UnityEngine.UI;
using WheelOfFortune.Common;

namespace WheelOfFortune.Ui
{
    [RequireComponent(typeof(Button))]
    public class SpinButtonController : MonoBehaviour
    {
        private Button _spinButton;

        private void Awake()
        {
            _spinButton = GetComponent<Button>();
        }

        private void Start()
        {
            _spinButton.onClick.AddListener(SpinButtonClick);
            GameActions.SpinFinish += OnSpinFinish;
        }

        private void OnDestroy()
        {
            _spinButton.onClick.RemoveAllListeners();
            GameActions.SpinFinish -= OnSpinFinish;
        }
        
        private void SpinButtonClick()
        {
            _spinButton.interactable = false;
            GameActions.SpinClick?.Invoke();
        }

        private void OnSpinFinish()
        {
            _spinButton.interactable = true;
        }
    }
}