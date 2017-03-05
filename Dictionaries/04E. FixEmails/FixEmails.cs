namespace _04E.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            var name = Console.ReadLine();

            var dict = new Dictionary<string, string>();

            while (name != "stop")
            {
                dict[name] = Console.ReadLine();

                if (!dict[name].Contains("uk") || !dict[name].Contains("us"))
                {
                    Console.WriteLine($"{name} -> {dict[name]}");
                }

                name = Console.ReadLine();
            }
        }
    }
}
