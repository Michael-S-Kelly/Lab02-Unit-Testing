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

        #region Navigation Menu
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
        #endregion

        #region Withdraw
        /// <summary>
        /// Basic orverall function of the Withdraw choice.  Collects the amount that the user wishes to withdraw and uses that information to execute the RemoveFunds Method.
        /// </summary>
        static void Withdraw()
        {
            try
            {
                Console.WriteLine("Please enter the amount you wish to withdraw from your funds: ");
                string inputmoney = Console.ReadLine();
                double amount = Convert.ToDouble(inputmoney);
                RemoveFunds(amount);
            }
            catch (FormatException formEx)
            {
                Console.WriteLine("You failed to enter a number in a numeric format in the Withdraw method.");
                Console.WriteLine(formEx.Message);
                Continue();
            }
        }

        public static double RemoveFunds(double amount)
        {
            try
            {
                if (balance <= amount)
                {
                    Console.WriteLine("That Amount is not allowed");
                    Continue();
                    return 0;
                }
                return amount;
            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
                Continue();
            }

            return 0;
        }

        #endregion

        #region Deposit
        static void Deposit()
        {

        }
        #endregion

        #region Continue
        /// <summary>
        /// This method is used to pause the program so the user is able to look at the information displayed before it is cleared
        /// </summary>
        static void Continue()
        {
            Console.WriteLine("Please press 'Enter' to continue.");
            Console.ReadLine();
        }
        #endregion
    }
}
