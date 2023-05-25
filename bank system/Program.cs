using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_system
{
    class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. Current balance: {balance:C}");
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. Current balance: {balance:C}");
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            bool exit = false;
            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bank Application");
                Console.WriteLine("----------------");
                Console.WriteLine("1. To  Deposit");
                Console.WriteLine("2.To Withdraw");
                Console.WriteLine("3.To Check Balance");
                Console.WriteLine("4. To Exit");
                Console.WriteLine();

                Console.Write("Enter your choice form 1 to 4: ");
                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter the deposit amount =  ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Enter the withdrawal amount =  ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                        account.Withdraw(withdrawalAmount);
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Current balance : {account.GetBalance():C}");
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }

        }
    }
}
