using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using WheelOfFortune.Common;
using WheelOfFortune.Generator;

namespace WheelOfFortune.Wheel
{
    public class AbstractWheel : MonoBehaviour, IWheel
    {
        [SerializeField] private List<Sector> _sectorList;
        [SerializeField] private RectTransform _rotatedObject;

        private void Start()
        {
            SetValues(FortuneGenerator.GetSectorValueList());
            GameActions.SpinClick += OnSpinClick;
        }

        private void OnDestroy()
        {
            GameActions.SpinClick -= OnSpinClick;
        }

        public void Rotate(int winIndex)
        {
            var endValue = new Vector3(
                0,
                0,
                3600 - _sectorList[winIndex].GetZRotateValue()
            );
            _rotatedObject.DOLocalRotate(endValue, 5f, RotateMode.FastBeyond360)
                .SetEase(Ease.OutCubic)
                .OnComplete(RotateFinished);
        }

        public void RotateFinished()
        {
            GameActions.SpinFinish?.Invoke();
        }

        public void SetValues(List<int> valueList)
        {
            for (int i = 0, count = Mathf.Min(_sectorList.Count, valueList.Count); i < count; i++)
            {
                _sectorList[i].SetValue(valueList[i]);
            }
        }

        private void OnSpinClick()
        {
            Rotate(FortuneGenerator.GetNewWinSectorIndex());
        }
    }
}