namespace _05ME.UserLogins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogins
    {
        public static void Main()
        {
            var delimeters = new char[] { '-', '>', ' ' };
            var userPasswordInput = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var dictUserPass = new Dictionary<string, string>();
            int failedLoginCounter = 0;

            while (userPasswordInput[0] != "login")
            {
                userPasswordInput = AddingUserWithPasswords(delimeters, userPasswordInput, dictUserPass);
            }

            while (userPasswordInput[0] != "end")
            {
                if (userPasswordInput[0] == "login")
                {
                    userPasswordInput = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    continue;
                }

                TryToLogin(delimeters, ref userPasswordInput, dictUserPass, ref failedLoginCounter);
            }

            Console.WriteLine($"unsuccessful login attempts: {failedLoginCounter}");
        }

        private static void TryToLogin(char[] delimeters, ref string[] userPasswordInput, Dictionary<string, string> dictUserPass, ref int failedLoginCounter)
        {
            string user = userPasswordInput[0];
            string pass = userPasswordInput[1];

            bool isPassValid = dictUserPass.ContainsValue(pass);

            if (!dictUserPass.ContainsKey(user) || !isPassValid)
            {
                failedLoginCounter++;
                Console.WriteLine($"{user}: login failed");
            }
            else
            {
                Console.WriteLine($"{user}: logged in successfully");
            }

            userPasswordInput = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        private static string[] AddingUserWithPasswords(char[] delimeters, string[] userPasswordInput, Dictionary<string, string> dictUserPass)
        {
            string user = userPasswordInput[0];
            string pass = userPasswordInput[1];

            dictUserPass[user] = pass;

            userPasswordInput = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();
            return userPasswordInput;
        }
    }
}

