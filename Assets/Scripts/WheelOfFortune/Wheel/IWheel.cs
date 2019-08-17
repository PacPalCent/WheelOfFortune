using System.Collections.Generic;

namespace WheelOfFortune.Wheel
{
    public interface IWheel
    {
        void Rotate(int winIndex);
        void RotateFinished();
        void SetValues(List<int> valueList);
    }
}
