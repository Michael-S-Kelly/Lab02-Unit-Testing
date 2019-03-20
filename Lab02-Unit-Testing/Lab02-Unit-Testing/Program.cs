using System;

namespace Lab02_Unit_Testing
{
    public class Program
    {
        public static double balance = 1000;
        public static double toWithdraw = 0;
        public static double toDeposit = 0;

        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        /// <summary>
        /// This is the navagation method to navigate to the different basic functions of the program
        /// </summary>
        /// <returns>As long as the method returns true the program will continue.</returns>
        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Please 'Enter' on of the following options.");
            Console.WriteLine("1) Withdraw Funds");
            Console.WriteLine("2) Deposit Funds");
            Console.WriteLine("3) Check Balance");
            Console.WriteLine("4) Exit");

            try
            {
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Withdraw();
                    return true;
                } else if (choice == "2")
                {
                    Deposit();
                    return true;
                } else if (choice == "3")
                {
                    Console.WriteLine($"Your account balance is {balance}.");
                    Continue();
                    return true;
                } else if (choice == "4")
                {
                    Console.WriteLine($"You have Withdrawn {toWithdraw}.");
                    Console.WriteLine($"You have Deposited {toDeposit}.");
                    Console.WriteLine($"Your current Balance is {balance}.");
                    Continue();
                    return false;
                } else
                {
                    Console.WriteLine("That is not an available option.");
                    Continue();
                    return true;
                }
                
            }

            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
                Continue();
                throw;
            }
        }

        
    }
}
