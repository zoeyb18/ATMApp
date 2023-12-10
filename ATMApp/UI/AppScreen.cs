using ATMApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            Console.Clear();
            //title of console window
            Console.Title = "My ATM App";


            Console.WriteLine("\n\n-----------Welcome to my ATM App-----------\n\n");

            Console.WriteLine("Please Insert Your ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate a physical card, read the number, and validate.");
            Utility.PressEnterToContinue();
        }

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number.");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN"));
            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.WriteLine("\nChecking card number and PIN...");
            Utility.PrintDotAnimation();
        }

        internal static void PrintLockScreen()
        {
            Console.Clear();
            Utility.PrintMessage("Your account it locked. Please go to the nearest branch to unlock your account. Thank You.", true);
            Utility.PressEnterToContinue();
            Environment.Exit(1);
        }
        internal static void WelcomeCustomer(string fullName)
        {
            Console.WriteLine($"Welcome back, {fullName}");
            Utility.PressEnterToContinue();
        }

        internal static void DisplayAppMenu()
        {
            Console.Clear();
            Console.WriteLine("------My ATM App Menu-------");
            Console.WriteLine(":                          :");
            Console.WriteLine("1. Account Balance         :");
            Console.WriteLine("2. Cash Deposit            :");
            Console.WriteLine("3. Withdrawal              :");
            Console.WriteLine("4. Transfer                :");
            Console.WriteLine("5. Transactions            :");
            Console.WriteLine("6. Logout                  :");
        }

        internal static void LogOutProgress()
        {
            Console.WriteLine("Thank you for using My ATM App");
            Utility.PrintDotAnimation();
            Console.Clear();
        }
    }
}
