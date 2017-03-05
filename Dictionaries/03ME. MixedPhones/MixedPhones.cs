namespace _03ME.MixedPhones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MixedPhones
    {
        public static void Main()
        {
            var separators = new char[] { ':', ' ' };

            var inputLine = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var phoneBook = new SortedDictionary<string, long>();

            while (inputLine[0] != "Over")
            {
                ArrangePhoneBook(inputLine, phoneBook);

                inputLine = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            PrintPhoneBook(phoneBook);
        }

        private static void PrintPhoneBook(SortedDictionary<string, long> phoneBook)
        {
            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }

        private static void ArrangePhoneBook(string[] inputLine, SortedDictionary<string, long> result)
        {
            long value;
            bool isName = long.TryParse(inputLine[0], out value);

            if (!isName && !result.ContainsKey(inputLine[0]))
            {
                result[inputLine[0]] = long.Parse(inputLine[1]);
            }
            else if (isName && !result.ContainsKey(inputLine[0]))
            {
                result[inputLine[1]] = value;
            }
        }
    }
}
