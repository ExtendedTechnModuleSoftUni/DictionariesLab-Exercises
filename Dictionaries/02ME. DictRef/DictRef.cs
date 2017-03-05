namespace _02ME.DictRef
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRef
    {
        public static void Main()
        {
            var separators = new char[] { '=', ' ' };

            var inputLine = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = new Dictionary<string, int>();

            while (inputLine[0] != "end")
            {
                int value;
                bool isInteger = int.TryParse(inputLine[1], out value);

                if (!result.ContainsKey(inputLine[0]) && isInteger)
                {
                    result[inputLine[0]] = value;
                }
                else if (result.ContainsKey(inputLine[0]) && isInteger)
                {
                    result[inputLine[0]] = value;
                }
                else if (!result.ContainsKey(inputLine[0]) && !isInteger)
                {
                    value = IsExist(inputLine, result);
                }
                else
                {
                    value = IsExist(inputLine, result);
                }

                inputLine = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            PrintResult(result);
        }

        private static void PrintResult(Dictionary<string, int> result)
        {
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }

        private static int IsExist(string[] inputLine, Dictionary<string, int> result)
        {
            int value;
            bool isExist = result.TryGetValue(inputLine[1], out value);

            if (isExist)
            {
                result[inputLine[0]] = value;
            }

            return value;
        }
    }
}
