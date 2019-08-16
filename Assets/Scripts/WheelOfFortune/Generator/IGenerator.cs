using System.Collections.Generic;

namespace WheelOfFortune.Generator
{
    public interface IGenerator
    {
        void Generate();
        List<int> GetSectorValueList();
        int GetWonSectorIndex();
    }
}