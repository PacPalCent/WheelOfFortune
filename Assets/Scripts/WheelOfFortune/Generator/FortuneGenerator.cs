using System.Collections.Generic;
using UnityEngine;

namespace WheelOfFortune.Generator
{
    public static class FortuneGenerator
    {
        private const int MinValue = 10;
        private const int MaxValue = 1000;
        private const int MinStep = 10;
        private const int FinalCoef = 100;
        private const int SectorCount = 16;
        private static readonly List<int> _sectorValueList = new List<int>();
        private static int _cachedWonIndex;

        public static void Generate()
        {
            _sectorValueList.Clear();
            while (_sectorValueList.Count < SectorCount)
            {
                var newValue = Random.Range(MinValue, MaxValue + 1);
                if (!IsNewValueIncorrect(newValue))
                {
                    _sectorValueList.Add(newValue);
                }
            }

            for (int i = 0, count = _sectorValueList.Count; i < count; i++)
            {
                _sectorValueList[i] *= FinalCoef;
            }
        }

        public static List<int> GetSectorValueList()
        {
            return _sectorValueList;
        }

        public static int GetLastWinValue()
        {
            return _sectorValueList[_cachedWonIndex];
        }

        public static int GetNewWinSectorIndex()
        {
            return _cachedWonIndex = Random.Range(0, SectorCount);
        }

        private static bool IsNewValueIncorrect(int value)
        {
            for (int i = 0, count = _sectorValueList.Count; i < count; i++)
            {
                if (
                    (
                        value < _sectorValueList[i] &&
                        value + MinStep > _sectorValueList[i]
                    ) ||
                    (
                        value > _sectorValueList[i] &&
                        value - MinStep < _sectorValueList[i]
                    ) ||
                    value.Equals(_sectorValueList[i])
                )
                {
                    return true;
                }
            }

            return false;
        }
    }
}