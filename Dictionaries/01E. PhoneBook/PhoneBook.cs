namespace _01E.PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhoneBook
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().Split().ToArray();

            var phoneBook = new Dictionary<string, string>();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    GetCommandA(command, phoneBook);

                }
                else if (command[0] == "S")
                {
                    GetCommandS(command, phoneBook);
                }

                command = Console.ReadLine().Split().ToArray();
            }
        }

        private static void GetCommandS(string[] command, Dictionary<string, string> phoneBook)
        {
            if (phoneBook.ContainsKey(command[1]))
            {
                Console.WriteLine($"{command[1]} -> {phoneBook[command[1]]}");
            }
            else
            {
                Console.WriteLine($"Contact {command[1]} does not exist.");
            }
        }

        private static void GetCommandA(string[] command, Dictionary<string, string> phoneBook)
        {
            if (!phoneBook.ContainsKey(command[1]))
            {
                phoneBook.Add(command[1], command[2]);
            }
            else
            {
                phoneBook[command[1]] = command[2];
            }
        }
    }
}
