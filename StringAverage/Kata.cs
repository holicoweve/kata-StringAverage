using System;
using System.Linq;

namespace Solution
{
    public class Kata
    {
        public static string AverageString(string input)
        {
            var error = "n/a";

            if (input == string.Empty)
                return error;
            if (input.Split(" ").Length == 0)
                return error;

            try
            {
                var average = input.Split(" ")
                    .ToList()
                    .Select(x => x.TextToInt())
                    .Average();
                return ((int) Math.Floor(average)).IntToText();
            }
            catch (ArgumentOutOfRangeException)
            {
                return error;
            }
        }
    }
}