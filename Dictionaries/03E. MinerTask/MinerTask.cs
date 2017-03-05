namespace _03E.MinerTask
{
    using System;
    using System.Collections.Generic;

    public class MinerTask
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            var dict = new Dictionary<string, int>();

            while (inputLine != "stop")
            {
                GetResourcesAndQuantities(inputLine, dict);

                inputLine = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }

        private static void GetResourcesAndQuantities(string inputLine, Dictionary<string, int> dict)
        {
            if (dict.ContainsKey(inputLine))
            {
                dict[inputLine] += int.Parse(Console.ReadLine());
            }
            else
            {
                dict[inputLine] = int.Parse(Console.ReadLine());
            }
        }
    }
}
