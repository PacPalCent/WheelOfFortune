using System.Collections.Generic;
using UnityEngine;

namespace WheelOfFortune.Generator
{
    public class FortuneGenerator : MonoBehaviour, IGenerator
    {
        private const int MinValue = 10;
        private const int MaxValue = 1000;
        private const int MinStep = 10;
        private const int FinalCoef = 100;
        private const int Se = 100;
        
        public void Main()
        {
            
        }


        public void Generate()
        {
            throw new System.NotImplementedException();
        }

        public List<int> GetSectorValueList()
        {
            throw new System.NotImplementedException();
        }

        public int GetWonSectorIndex()
        {
            throw new System.NotImplementedException();
        }
    }
}