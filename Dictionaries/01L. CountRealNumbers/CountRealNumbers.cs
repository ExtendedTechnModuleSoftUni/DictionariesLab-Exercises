namespace _01L.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountRealNumbers
    {
        static void Main()
        {
            var realNumbersInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var counts = new SortedDictionary<double, int>();

            foreach (var num in realNumbersInput)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 0;
                }

                counts[num]++;
            }

            foreach (var kvp in counts)
            {
                //string timeString = kvp.Value == 1 ? "time" : "times";

                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
