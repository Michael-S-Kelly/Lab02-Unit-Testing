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

        static bool MainMenu()
        {

        }
    }
}
