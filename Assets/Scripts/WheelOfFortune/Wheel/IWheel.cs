using System.Collections.Generic;

namespace WheelOfFortune.Wheel
{
    public interface IWheel
    {
        void Rotate();
        void SetValues(List<int> valueList);
    }
}
