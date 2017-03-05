namespace _02E.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().Split().ToArray();
            var sortedPhoneBook = new SortedDictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    GetCommandA(command, sortedPhoneBook);
                }
                else if (command[0] == "S")
                {
                    GetCommandS(command, sortedPhoneBook);
                }
                else
                {
                    PrintPhoneBook(sortedPhoneBook);
                }

                command = Console.ReadLine().Split().ToArray();
            }
        }

        private static void PrintPhoneBook(SortedDictionary<string, string> sortedPhoneBook)
        {
            foreach (var kvp in sortedPhoneBook)
            {
                string contactName = kvp.Key;
                string phoneNumber = kvp.Value;

                Console.WriteLine($"{contactName} -> {phoneNumber}");
            }
        }

        private static void GetCommandA(string[] command, SortedDictionary<string, string> sortedPhoneBook)
        {
            if (!sortedPhoneBook.ContainsKey(command[1]))
            {
                sortedPhoneBook.Add(command[1], command[2]);
            }
            else
            {
                sortedPhoneBook[command[1]] = command[2];
            }
        }

        private static void GetCommandS(string[] command, SortedDictionary<string, string> sortedPhoneBook)
        {
            if (sortedPhoneBook.ContainsKey(command[1]))
            {
                Console.WriteLine($"{command[1]} -> {sortedPhoneBook[command[1]]}");
            }
            else
            {
                Console.WriteLine($"Contact {command[1]} does not exist.");
            }
        }
    }
}
