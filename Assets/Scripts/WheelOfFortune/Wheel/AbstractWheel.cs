using System.Collections.Generic;
using UnityEngine;

namespace WheelOfFortune.Wheel
{
    public class AbstractWheel : MonoBehaviour, IWheel
    {
        public void Rotate()
        {
            throw new System.NotImplementedException();
        }

        public void SetValues(List<int> valueList)
        {
            throw new System.NotImplementedException();
        }
    }
}