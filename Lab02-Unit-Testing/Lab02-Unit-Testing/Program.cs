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
                Continue();
            }
            catch (FormatException formEx)
            {
                Console.WriteLine("You failed to enter a number in a numeric format in the Withdraw method.");
                Console.WriteLine(formEx.Message);
                Continue();
            }
        }

        /// <summary>
        /// This method checks to see if the amount entered in the Withdraw method is leginimate.  If leginimate, it subtracts the amount from the balance and adds to the running withdrawal total
        /// </summary>
        /// <param name="amount">amount that the user wishes to withdraw</param>
        /// <returns>returns amount if the amount is leginimate or 0 if it is not</returns>
        public static double RemoveFunds(double amount)
        {
            try
            {
                if (balance <= amount)
                {
                    Console.WriteLine("That Amount is not allowed");
                    return 0;
                } else if (amount < 0)
                {
                    Console.WriteLine("Silly, you can't cheat by Withdrawing a negative amount");
                    return 0;
                } else if (toWithdraw == 0)
                {
                    balance -= amount;
                    toWithdraw += amount;
                    Console.WriteLine($"You have withdrawn {amount} this transaction.  Your new balance is {balance}");
                    return amount;
                } else if (toWithdraw != 0)
                {
                    balance -= amount;
                    toWithdraw += amount;
                    Console.WriteLine($"You have withdrawn {amount} this transaction and {toWithdraw} this session.  Your new balance is {balance}");
                    return amount;
                } else
                {
                    Console.WriteLine("I'm sorry, that amount is not allowed.");
                    return 0;
                }

                
            }
            catch (FormatException formEx)
            {
                Console.WriteLine("You failed to enter a number in a numeric format in the RemoveFunds method.");
                Console.WriteLine(formEx.Message);
                Continue();
                throw;
            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
                Continue();
                throw;
            }

        }

        #endregion

        #region Deposit
        /// <summary>
        /// Basic orverall function of the Deposit choice.  Collects the amount that the user wishes to deposit and uses that information to execute the AddFunds Method.
        /// </summary>
        static void Deposit()
        {
            Console.WriteLine("Please enter the amount you wish to deposit to your funds: ");
            string inputmoney = Console.ReadLine();
            double amount = Convert.ToDouble(inputmoney);
            AddFunds(amount);
            Continue();
        }

        /// <summary>
        /// This method checks to see if the amount entered in the Deposit method is leginimate.  If leginimate, it adds the amount to the balance and adds to the running deposit total
        /// </summary>
        /// <param name="amount">amount that the user wishes to deposit</param>
        /// <returns>returns amount if the amount is leginimate or 0 if it is not</returns>
        public static double AddFunds(double amount)
        {
            try
            {
                if (amount < 0)
                {
                    Console.WriteLine("Silly, you can't deposit a negitive amount.");
                    return 0;
                } else if (toDeposit == 0)
                {
                    balance += amount;
                    toDeposit += amount;
                    Console.WriteLine($"You have deposited ${amount} this transaction.  Your new balance is ${balance}");
                    return amount;
                } else if (toDeposit != 0)
                {
                    balance += amount;
                    toDeposit += amount;
                    Console.WriteLine($"You have deposited ${amount} this transaction and ${toDeposit} this session.  Your new balance is ${balance}");
                    return amount;
                } else
                {
                    Console.WriteLine("Sorry, you have entered an amount that is not allowed.");
                    return 0;
                }
            }
            catch (Exception genEx)
            {
                Console.WriteLine(genEx.Message);
                throw;
            }
            
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
