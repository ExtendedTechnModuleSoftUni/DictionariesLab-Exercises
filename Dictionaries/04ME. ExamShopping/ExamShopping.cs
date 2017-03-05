namespace _04ME.ExamShopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExamShopping
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split().ToArray();

            var itemQuantity = new Dictionary<string, int>();

            while (inputLine[0] != "exam")
            {
                if (inputLine[0] == "stock")
                {
                    stockInventory(inputLine, itemQuantity);
                }
                else if (inputLine[0] == "buy")
                {
                    shoppingTime(inputLine, itemQuantity);
                }

                inputLine = Console.ReadLine().Split().ToArray();
            }

            PrintLeftProduct(itemQuantity);
        }

        private static void PrintLeftProduct(Dictionary<string, int> itemQuantity)
        {
            foreach (var kvp in itemQuantity)
            {
                if (kvp.Value == 0)
                {
                    continue;
                }

                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }

        private static void shoppingTime(string[] inputLine, Dictionary<string, int> itemQuantity)
        {
            string item = inputLine[1];
            int quantity = int.Parse(inputLine[2]);

            if (!itemQuantity.ContainsKey(item))
            {
                Console.WriteLine($"{item} doesn't exist");
            }
            else
            {
                if (itemQuantity[item] == 0)
                {
                    Console.WriteLine($"{item} out of stock");
                }

                itemQuantity[item] = Math.Max(itemQuantity[item] - quantity, 0);
            }
        }

        private static void stockInventory(string[] inputLine, Dictionary<string, int> itemQuantity)
        {
            string item = inputLine[1];
            int quantity = int.Parse(inputLine[2]);

            if (!itemQuantity.ContainsKey(item))
            {
                itemQuantity[item] = quantity;
            }
            else
            {
                itemQuantity[item] += quantity;
            }
        }
    }
}

