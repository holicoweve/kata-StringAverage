using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Solution
{
    public static class Extensions
    {
        private static readonly string[] Words = new string[]
        {
            "zero", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine"
        };

        public static int TextToInt(this string input)
        {
            if(Words.Contains(input)!=true)
                throw new ArgumentOutOfRangeException();
            return Array.IndexOf(Words, input);
        }


        public static string IntToText(this int input)
        {
            if (input < 0 || input > Words.Length - 1)
                throw new AbandonedMutexException();
            return Words[input];
        }
    }
}