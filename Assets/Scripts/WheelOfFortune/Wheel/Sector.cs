using Common;
using TMPro;
using UnityEngine;

namespace WheelOfFortune.Wheel
{
    public class Sector : MonoBehaviour
    {
        [SerializeField] private TMP_Text _valueTextField;
        private RectTransform _cachedTransform;
        
        private void Awake()
        {
            _cachedTransform = GetComponent<RectTransform>();
        }

        public void SetValue(int value)
        {
            _valueTextField.text = value.ToString();
        }

        public float GetZRotateValue()
        {
            return _cachedTransform.localEulerAngles.z;
        }
    }
}