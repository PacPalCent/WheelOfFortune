using System;

namespace Common
{
    public static class ConvertUtil
    {
        private static readonly string[] BigNumsChars = {"", "K", "M", "B"};

        public static string ConvertK(this int value)
        {
            var temp = value;
            var ranks = 0;
            while ((temp = temp / 1000) > 0)
            {
                ranks++;
            }
            var finalRank = BigNumsChars.Length > ranks
                ? ranks
                : BigNumsChars.Length - 1;
            return (value / Math.Pow(1000, finalRank)).ToString("0.##") + BigNumsChars[finalRank];
        }
    }
}