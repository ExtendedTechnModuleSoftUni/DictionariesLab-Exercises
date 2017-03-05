namespace _06ME.FilterBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterBase
    {
        public static void Main()
        {
            var delimeters = new char[] { '-', '>', ' ' };
            var inputLine = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var nameAge = new Dictionary<string, int>();
            var nameSalary = new Dictionary<string, double>();
            var namePosition = new Dictionary<string, string>();

            while (inputLine[0] != "filter")
            {
                string name = inputLine[0];
                string ageSalaryPossition = inputLine[1];

                int age;
                var isAge = int.TryParse(ageSalaryPossition, out age);

                if (isAge)
                {
                    nameAge[name] = age;
                    inputLine = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    continue;
                }

                double salary;
                var isSalary = double.TryParse(ageSalaryPossition, out salary);

                if (isSalary)
                {
                    nameSalary[name] = salary;
                }
                else
                {
                    namePosition[name] = ageSalaryPossition;
                }

                inputLine = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            inputLine = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string informationNeeded = inputLine[0];

            if (informationNeeded == "Age")
            {
                PrintInformationForAges(nameAge);
            }
            else if (informationNeeded == "Salary")
            {
                PrintInformationForSalaries(nameSalary);
            }
            else
            {
                PrintInformationForPositions(namePosition);
            }
        }

        private static void PrintInformationForPositions(Dictionary<string, string> namePosition)
        {
            foreach (var kvp in namePosition)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"Position: {kvp.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }

        private static void PrintInformationForSalaries(Dictionary<string, double> nameSalary)
        {
            foreach (var kvp in nameSalary)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"Salary: {kvp.Value:f2}");
                Console.WriteLine(new string('=', 20));
            }
        }

        private static void PrintInformationForAges(Dictionary<string, int> nameAge)
        {
            foreach (var kvp in nameAge)
            {
                Console.WriteLine($"Name: {kvp.Key}");
                Console.WriteLine($"Age: {kvp.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}
